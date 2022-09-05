using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{         
    public enum Trafic
    {
      Red,
      Yellow,
      Green

    }
    public enum Race : int
    {
        Elif = 0,
        Ork = 1,
        Teerain = 2
    }

    class Program
    {
        static void Main(string[] args)
        {
            string name = "abcdcdbcdba";
            string sub = name.Substring(5);
            string sub2 = name.Substring(3, 8);
            Console.WriteLine(sub);
            Console.WriteLine(sub2);

        }

        static void Swap(ref int a, ref int b)
        {
            Console.WriteLine($"Oroginal a = {a}, b = {b}");
            int tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine($"Swapepd a = {a}, b = {b}");
        }
        static void AddNumbers(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }
        static void Dicrtinory()
        {
            var peppeol = new Dictionary<int, string>();
            peppeol.Add(1, "john");
            peppeol.Add(2, "bob");
            peppeol.Add(3, "alic");

            string name = peppeol[1];
            Console.WriteLine(name);
            Console.WriteLine("Iterating over keys");
            Dictionary<int, string>.KeyCollection keys = peppeol.Keys;
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Iterating over values");
            Dictionary<int, string>.ValueCollection values = peppeol.Values;
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Itarating over pairs");
            foreach (KeyValuePair<int, string> pair in peppeol)
            {
                Console.WriteLine($"Key{pair.Key}, Value{pair.Value}");
            }
            Console.WriteLine($"Count{peppeol.Count}");
            bool cointains = peppeol.ContainsKey(1);
            bool cointains2 = peppeol.ContainsValue("John");

            Console.WriteLine($"Contains key{cointains}, Contains Value {cointains2}");
            peppeol.Remove(1);
            Console.WriteLine(peppeol.Remove(1));

            if (peppeol.TryGetValue(2, out string value))
            {
                Console.WriteLine($"Key value{value}");
            }
            else
            {
                Console.WriteLine("Failed to get");
            }
            peppeol.Clear();


        }
        static void List()
        {
            var intList = new List<int>() { 7, 5, 9, 12 };
            intList.Add(7);

            int[] intArray = { 1, 2, 3 };
            intList.AddRange(intArray);

            if (intList.Remove(1))
            {

            }
            else
            {

            }
            intList.RemoveAt(0);

            intList.Reverse();

            bool contains = intList.Contains(3);

            int min = intList.Min();
            int max = intList.Max();

            Console.WriteLine($"Min{min},Max{max}");

            int index = intList.IndexOf(2);
            int lstofindex = intList.LastIndexOf(2);
            Console.WriteLine($"IndexOf {index}, LasrIndex{lstofindex} ");

            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write(intList[i]);
            }
            foreach (int n in intList)
            {
                Console.Write(n);
            }
            Console.ReadLine();

        }
        static void PaswordLogin()
        {
            string login = "joinsvalor";
            string password = "qwerty";

            int tries = 1;
            while (tries <= 3)
            {
                Console.WriteLine("Login");
                string userLogin = Console.ReadLine();

                Console.WriteLine("Pasword");
                string passwordLogin = Console.ReadLine();
                if (userLogin == login && passwordLogin == password)
                {
                    Console.WriteLine("Enter System");
                    break;
                }
                tries++;
            }
            if (tries == 4)
            {
                Console.WriteLine("The number of available tries have been exceeded");
            }
        }
        static void Factorial()
        {
            Console.WriteLine("Give me a number");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
        static void NumbersAvereg()
        {
            Console.WriteLine("Give me 10 numbers");
            int[] numbers = new int[10];
            int inputCount = 0;
            while (inputCount < 10)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[inputCount] = number;
                inputCount++;
                if (number == 0)
                {
                    break;
                }

            }
            int sum = 0;
            int count = 0;
            foreach (int n in numbers)
            {
                if (n > 0 && n % 3 == 0)
                {
                    sum += n;
                    count++;
                }
            }
            double averege = (double)sum / count;
            Console.WriteLine(averege);

        }
        static void StwintchCase()
        {
            int month = int.Parse(Console.ReadLine());
            string seson = string.Empty;
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    seson = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    seson = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    seson = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    seson = "Autumn";
                    break;
                default:
                    throw new ArgumentException("Unexpected nymber of month");
                    break;
            }
            Console.WriteLine(seson);

            Console.ReadLine();

            int weinDreings = int.Parse(Console.ReadLine());
            string name = string.Empty;

            switch (weinDreings)
            {
                case 5:
                    name = "Деревянная свадьба";
                    break;
                case 10:
                    name = "Оловянная свадьба";
                    break;
                case 15:
                    name = "Хрустальная свадьба";
                    break;
                case 20:
                    name = "Серебрянная  свадьба";
                    break;
                case 25:
                    name = "Жемчужина свадьба";
                    break;
                case 30:
                    name = "Фарфорофвая свадьба";
                    break;
                default:
                    name = "Nothing";
                    break;



            }
            Console.WriteLine(name);
        }
        static void BreakAndConinue()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, };

            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                }
                if (n % 2 == 0)
                {
                    continue;
                    

                }
            }

            Console.ReadLine();

            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Numbers={numbers[i]}");

                for (int j = 0; j < letters.Length; j++)
                {
                    if (numbers[i] == j)
                        break;
                    Console.Write($"{letters[j]}");
                }
                Console.WriteLine();
            }
        }
        static void WhileOperation()
        {
            int age = 30;
            while (age < 18)
            {
                Console.WriteLine("First while loop");
                Console.WriteLine("What is your age");
                age = int.Parse(Console.ReadLine());

            }
            do
            {
                Console.WriteLine("What is your age");
                age = int.Parse(Console.ReadLine());
            }
            while (age < 18);

            int[] numbers = { 1, 2, 3, 4, 5, 6, };
            int i = 0;
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i] + " ");
                i++;
            }
        }
        static void ForAndForeach()
        {
            int[] numbres = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            for (int i = 0; i < numbres.Length; i++)
            {
                Console.Write(numbres[i] + " ");
            }
            Console.WriteLine();
            for (int i = numbres.Length - 1; i >= 0; i--)
            {
                Console.Write(numbres[i] + " ");
            }
            Console.WriteLine();
            for (int j = 0; j < numbres.Length; j++)
            {
                if (numbres[j] % 2 == 0)
                {
                    Console.Write(numbres[j] + " ");
                }
            }
            Console.WriteLine();
            foreach (int val in numbres)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
            int[] num = { 1, -7, 3, -8, -3, 6, 0 };
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    int atI = num[i];
                    int atJ = num[j];
                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Index({i};{j})");
                    }
                }
            }
            Console.WriteLine();
            int[] number = { 1, -7, 3, -8, -3, 6, 0 };
            for (int i = 0; i < number.Length - 2; i++)
            {
                for (int j = i + 1; j < number.Length - 1; j++)
                {
                    for (int k = j + 1; k < number.Length; k++)
                    {
                        int atI = number[i];
                        int atJ = number[j];
                        int atK = number[k];
                        if (atI + atJ + atK == 0)
                        {
                            Console.WriteLine($"Pair ({atI};{atJ};{atK}). Index({i};{j};{k})");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
        static void Max()
        {
            Console.WriteLine("First");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Second");
            int b = int.Parse(Console.ReadLine());
            if (b > a)
            {
                Console.WriteLine("B is bigger ");

            }
            if (b < a)
            {
                Console.WriteLine("A is bigger");
            }
            else
            {
                Console.WriteLine("Don't have maximum");
            }
            int max = a > b ? a : b;
            Console.WriteLine(max);
        }
        static void ControlFlow()
        {
            Console.WriteLine("What's your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What's your weight?");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("What's your heigh");
            double heigh = double.Parse(Console.ReadLine());

            double BoddyMassIndex = weight / (heigh * heigh);

            bool isTooLow = BoddyMassIndex <= 18.5;
            bool isTooNormal = BoddyMassIndex >= 18.5 && BoddyMassIndex <= 25;
            bool isTooHigh = BoddyMassIndex >= 25 && BoddyMassIndex <= 30;
            bool isTooFat = BoddyMassIndex > 30;

            bool isFat = isTooHigh || isTooFat;

            if (isFat)
            {
                Console.WriteLine("Lose some weigth");
            }
            else
            {
                Console.WriteLine("Its'ok");
            }
            if (!isFat)
            {
                Console.WriteLine("Good shape");
            }
            else if (isTooLow)
            {
                Console.WriteLine("Need weight");
            }
            else if (isTooNormal)
            {
                Console.WriteLine("Very good");
            }
            else if (isTooHigh)
            {
                Console.WriteLine("Ok");

            }
            else
            {
                Console.WriteLine("You need to lose some weigth");
            }
            if (isFat || isTooFat)
            {
                Console.WriteLine("You need lose");
            }

            string description = age > 18 ? "You cand drink alcohol" : "You should go to school";
            Console.WriteLine(description);
        }
        static void DateTimeOperation()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            Console.WriteLine($"it's{now.Date}, {now.Minute} ");

            DateTime dt = new DateTime(2016, 2, 28);
            DateTime newDt = dt.AddDays(1);
            Console.WriteLine(newDt);

            TimeSpan t = now - dt;
            t = now.Subtract(dt);
            Console.WriteLine(t.Days);
        }
        static void ArraysOperation()
        {
            int[] a8;
            a8 = new int[10];

            int[] a9 = new int[5] { 1, 2, 3, 4, 5 };

            int[] a10 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(a10[0]);
            int numbre = a10[4];
            Console.WriteLine(numbre);
            Console.WriteLine(a10.Length);
            Console.WriteLine(a10[a10.Length - 1]);

            string s1 = "abcdcdscdsd";
            char first = s1[0];
            char last = s1[s1.Length - 1];
            Console.WriteLine($"first:{first}.last:{last}");

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = Array.BinarySearch(numbers, 7);
            Console.WriteLine(index);

            int[] copy = new int[10];
            Array.Copy(numbers, copy, numbers.Length);

            int[] anotherCopy = new int[10];
            copy.CopyTo(anotherCopy, 0);

            Array.Reverse(copy);
            foreach (var c in copy)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();
            Array.Sort(copy);
            foreach (var c in copy)
            {
                Console.WriteLine(c);
            }

            Array.Clear(copy, 0, copy.Length);

            int[] a1;
            a1 = new int[10];
            int[] a2 = new int[5];
            int[] a3 = new int[5] { 1, 2, 3, 4, 5 };
            int[] a4 = { 1, 2, 3, 4, 5 };

            Array myArray = new int[5];
            Array myArray2 = Array.CreateInstance(typeof(int), 5);
            myArray.SetValue(12, 0);
            Console.WriteLine(myArray.GetValue(0));

            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[1];
            jaggedArray[1] = new int[2];
            jaggedArray[2] = new int[3];
            jaggedArray[3] = new int[4];

            Console.WriteLine("Jadge array:");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    string st = Console.ReadLine();
                    jaggedArray[i][j] = int.Parse(st);
                }

            }
            Console.WriteLine();
            Console.WriteLine("Printing the elemets");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            Array myArr = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 });
            myArray.SetValue(2019, 1);
            myArray.SetValue(2020, 2);
            myArray.SetValue(2021, 3);
            myArray.SetValue(2022, 4);

            Console.WriteLine($"Starting index:{myArr.GetLowerBound(0)}");
            Console.WriteLine($"Starting index:{myArr.GetUpperBound(0)}");

            for (int i = myArr.GetLowerBound(0); i <= myArr.GetUpperBound(0); i++)
            {
                Console.WriteLine($"{myArr.GetValue(i)} at index {i}");
            }
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine($"{myArr.GetValue(i)} at index {i}");
            }


        }
        static void MathIntel()
        {
            Console.WriteLine(Math.Pow(2, 8));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Sqrt(8));

            Console.WriteLine(Math.Round(1.7));
            Console.WriteLine(Math.Round(1.2));
            Console.WriteLine(Math.Round(1.5));

            Console.WriteLine();

            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));
        }
        static void CastType()
        {
            byte b = 3; // 0000 0011
            int i = b;// 0000 0000 0000 0000 0000 0000 0000 0011
            long l = i; // 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011
            Console.WriteLine(l);
            float f = i; // 3.0
                         // Console.WriteLine(f);
                         // Явное приведение
            b = (byte)i;
            Console.WriteLine(b);
            i = (int)f;
            Console.WriteLine(i);
            f = 3.1f;
            i = (int)f;
            Console.WriteLine(i);

            string s = "1";
            i = int.Parse(s);
            Console.WriteLine(i);

            int x = 5;
            int result = x / 2;
            Console.WriteLine(result);

            double result2 = (double)x / 2;
            Console.WriteLine(result2);
        }
        static void OperationWihConsole()
        {
            Console.WriteLine("Hi , my name is");
            string name = Console.ReadLine();
            string sentence = $"Your name is {name}";
            Console.WriteLine(sentence);

            Console.WriteLine("Hi, please tell your age");
            string input = Console.ReadLine();
            int age = int.Parse(input);
            string sentrnce = $"Your age is {age}";
            Console.WriteLine(sentrnce);

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.Write("New Style");
            Console.Write("New Style");
        }
        static void OperationWithString()
        {
            string name = "abcdcdbcdba";
            bool firstmethod = name.Contains("cdb");
            Console.WriteLine(firstmethod);

            bool endwith = name.EndsWith("dba");
            Console.WriteLine(endwith);

            bool startwith = name.StartsWith("abcd");
            Console.WriteLine(startwith);

            int index = name.IndexOf("c");
            Console.WriteLine(index);

            int lastindex = name.LastIndexOf("c");
            Console.WriteLine(lastindex);
            
            Console.WriteLine(name.Length);
            string sub = name.Substring(5);
            string sub2 = name.Substring(3,8);
            Console.WriteLine(sub);
            Console.WriteLine(sub2);
            //Concat
            string nameConcat = string.Concat("My", "name", "is", "John");
            Console.WriteLine(nameConcat);
            //Join
            string nameJoin = string.Join(" ", "My", "name", "is", "John");
            Console.WriteLine(nameJoin);
            //Insert
            string nameInsert = nameConcat.Insert(0, "By The Way");
            Console.WriteLine(nameInsert);
            //Remove
            nameConcat = nameConcat.Remove(0, 2);
            Console.WriteLine(nameConcat);
            //Replace
            string replaced = nameConcat.Replace("n", "z");
            Console.WriteLine(replaced);
            //Split
            string data = "12;28;34;25;64";
            string[] splitData = data.Split(';');
            string first = splitData[0];
            Console.WriteLine(first);
            //ToCharArray
            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[0]);
            Console.WriteLine(chars[1]);
            //ToLower
            string Lower = nameConcat.ToLower();
            Console.WriteLine(Lower);
            //ToUpper
            string Upper = nameConcat.ToUpper();
            Console.WriteLine(Upper);
            //Trim
            string john = " My Name i John";
            Console.WriteLine(john.Trim());

            StringBuilder sb = new StringBuilder();
            //Append
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("John ");
            sb.AppendLine("! ");
            sb.AppendLine("Hello ");


            string str = sb.ToString();
            Console.WriteLine(str);
            // Виды сравнения
            string str1 = "abcde";
            string str2 = "abcde";
            bool areEqual = str1 == str2;
            Console.WriteLine(areEqual);

            areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            Console.WriteLine(areEqual);
            string s1 = "Strasse";
            string s2 = "Strae";
            areEqual = s1 == s2;
           

        }
        static void EmptyString()
        {
            string str = string.Empty;
            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = "b";
            string nullString = null;
            
            bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(isNullOrEmpty);

            Console.WriteLine(isNullOrEmpty);
            bool IsnullOrSpace = string.IsNullOrWhiteSpace(whiteSpaced);
            Console.WriteLine(whiteSpaced);

            
          
        }
        static void FormatWithString()
        {
            //Format
            string name = "John";
            int age = 30;
            string str1 = string.Format("My name is {0} and I'm {1}", name, age);
            string str2 = "My name is" + name + "and I'm" + age;
            string str3 = $"My name is {name} and I'm {age}";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            //\n
            string str4 = $"My name is \n {name}";
            Console.WriteLine(str4);
            //\t
            string str5 = $"I'm \t {age}";
            Console.WriteLine(str5);
            //Environment.NewLine
            string str6 = $"My name is{Environment.NewLine} John";
            Console.WriteLine(str6);
            //"" В строке
            string str7 = "My name is Nikita and i'm \"good\" programer";
            Console.WriteLine(str7);
            string str8 = "C:\\tmp\test_file.txt";
            Console.WriteLine(str8);
            //@
            string str9 = @"C:\\tmp\test_file.txt";
            Console.WriteLine(str9);
            // {0:d}
            int answer = 42;
            string result = string.Format("{0:d}", answer);
            string result2 = string.Format("{0:d4}", answer);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            //{0:f}
            result = string.Format("{0:f}", answer);
            result2 = string.Format("{0:f4}", answer);
            Console.WriteLine(result);
            Console.WriteLine(result2);

            Console.OutputEncoding = Encoding.UTF8;
            double money = 12.8;
            result = string.Format("{0:C}", money);
            result2 = string.Format("{0;C2}", money);
            Console.WriteLine(money.ToString("C2"));
            Console.WriteLine(result2);

        }
    }
 }   
    
       

