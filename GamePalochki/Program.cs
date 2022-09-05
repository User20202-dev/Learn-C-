using GamePalochki.Sticks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePalochki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
       

        private static void Game_EndOfGame(Player player)
        {
            Console.WriteLine($"Winner{player}");
        }

        private static void Game_HumanTurnToMakeMove(object sender, int RemainSticks)
        {
            Console.WriteLine($"Remain sticks : {RemainSticks}");
            Console.WriteLine("Take some sticks");

            bool TakeCorectly = false;
            while (!TakeCorectly)
            {
                if (int.TryParse(Console.ReadLine(), out int takenSticks))
                {
                    var game = (SticksGame)sender;
                    try
                    {
                        game.HumanTakes(takenSticks);
                        TakeCorectly = true;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private static void Game_MachinePlayed(int SticksTaken)
        {
            Console.WriteLine($"Machine took: {SticksTaken}");
        }
    }
}
