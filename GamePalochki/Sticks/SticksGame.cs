using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePalochki.Sticks
{
    public enum GameStatus
    {
        NotStarted,
        InProgress,
        GameOver,

    }
    public enum Player
    {
        Human,Computer
    }
    public class SticksGame
    {
        private readonly Random randomiazer;
        private int InitialSticksNumber { get; }
        public Player Turn{ get; private set; }
        public int RemainingSticks { get; private set; }
        public GameStatus GameStatus { get; private set; }
        public event Action<int> MachinePlayed;
        public event EventHandler<int> HumanTurnToMakeMove;

        public event Action<Player> EndOfGame;

        public SticksGame(int initialStickNumber, Player WhoMakesFirstMove)
        {
            if(initialStickNumber < 7 || initialStickNumber > 30)
                throw new ArgumentOutOfRangeException("Initial number of sticks shoulde be >= 7 and <= 30");

           
            randomiazer = new Random();
            InitialSticksNumber = initialStickNumber;
            GameStatus = GameStatus.NotStarted;
            RemainingSticks = InitialSticksNumber;
            Turn = WhoMakesFirstMove;

        }
        public void HumanTakes(int sticks)
        {
            if (sticks < 1 || sticks > 3)
            {
                throw new ArgumentException("You can take from 1 to 3 ");
            }
            if (sticks > RemainingSticks)
            {
                throw new ArgumentException($"You can't make more then remining.REmains{RemainingSticks}");
            }

        }
        public void Start()
        {
           if(GameStatus == GameStatus.GameOver)
           {
                RemainingSticks = InitialSticksNumber;

           }
           if(GameStatus == GameStatus.InProgress)
           {
                throw new InvalidOperationException("Can't call Start when game is already in progress");

           }
           GameStatus = GameStatus.InProgress;
           while(GameStatus == GameStatus.InProgress)
            {
                if(Turn == Player.Computer)
                {
                    MachineMakeMoves();
                }
                else
                {
                    HumanMakeMoves();
                }
                FierEndofGameIfRequired();

                Turn = Turn == Player.Computer ? Player.Human : Player.Computer;
            }
        }

        private void FierEndofGameIfRequired()
        {
            if(RemainingSticks==0)
            {
                GameStatus = GameStatus.GameOver;
                if(EndOfGame != null)
                {
                    EndOfGame(Turn = Turn == Player.Computer ? Player.Human : Player.Computer);
                }
            }
        }

        private void HumanMakeMoves()
        {
            if(HumanTurnToMakeMove != null)
            HumanTurnToMakeMove(this, RemainingSticks);
        }

        private void MachineMakeMoves()
        {
            int max = RemainingSticks >= 3 ? 3 : RemainingSticks;
            int sticks = randomiazer.Next(1, max);
            TakeSticks(sticks);
            if(MachinePlayed != null)
            {
                MachinePlayed(sticks);
            }
        }

        private void TakeSticks(int sticks)
        {
            RemainingSticks -= sticks;

        }
    }
}
