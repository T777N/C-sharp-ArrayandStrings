using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_sharp_ArrayandStrings
{
    class Program
    {
        static int point;
        static int tA;
        static void Question(int size)
        {
            string[] questions = new string[10] { 
                $" 1) Where is Azerbaijan Capital ?             ",
                $" 2) Where is Turkey Capital ? ",
                $" 3) Where is Pakistan Capital ? ",
                $" 4) 4 qelem ve 3 defterin deyeri 6 qelem ve 2 defterin deyerine beraberdir . 4 defterin deyerine nece qelem almaq olar ? ",
                $" 5) 2 + 2 : 2 ? ",
                $" 6) Azalan cixilandan 10 vahit boyuk olarsa , ferq 5-in nece qati olar ? ",
                $" 7) ( one ) bu sozun tercumesi nedir ? ",
                $" 8) ( Cherry ) bu hansi meyvenin adidir ? ",
                $" 9) ( age ) bu suzun menasi nedir ? ",
                $" 10) Atamin yasi menim yasimin 3 qatindan 2 vahi boyukdur, 17 il sonra Babamin 90 yasi tamam oldu , atam babamin 23 yasinda dunyaya gelib . Menim indi nece yasim var ? :D " 
            };
            Console.WriteLine(questions[size-1]);
           
        }
        static string Answer(int size1,int size2)
        {
            string[,] answers = new string[,] {
                { $"Baku", "Naxcivan", "Ganja" },
                {$"Istanbul","Ankara","Adana"},
                {$"Islamabad","Paris","Dadish"},
                {$"12","8","10"},
                {$"4","2","3"},
                {$"4","2","3"}, 
                {$"1","2","3"},
                {$"Alma","Banan","Gilas"}, 
                {$"goz","yash","kondisioner"},
                {$"12","14","16"},
                
            };
            Console.WriteLine(answers[size1-1,size2-1]);
            return answers[size1 - 1, size2 - 1];
        }
        static bool TrueAnswers(int index,string ansver)
        {
            string[] trueAnsvers = new string[10]
            {
                "Baku","Ankara","Islamabad","8","3","2","1","Gilas","yash","14"
            };
            if(trueAnsvers[index - 1] == ansver)
            {
            return true;
            }
            return false;

        }
        static int lastRandom=0;
        static int[] getRandom()
        {
            Random r = new Random();
            int random = r.Next(1, 4);
            int[] randomArr = new int[3];
            randomArr[0] = random;

            int random2 = r.Next(1, 4);
            if (random != random2)
            {
                randomArr[1] = random2;  
            }
            else
            {
                bool a = true;
                while (a)
                {
                    random2 = r.Next(1, 4);
                    if (random != random2)
                    {
                        randomArr[1] = random2;
                        a = false;
                    }
                }
            }

            int random3 = r.Next(1, 4);
            if (random != random2&&random!=random3&&random2!=random3)
            {
                randomArr[2] = random3;
            }
            else
            {
                bool a = true;
                while (a)
                {
                    random3 = r.Next(1, 4);
                    if (random != random2 && random != random3 && random2 != random3)
                    {
                        randomArr[2] = random3;
                        a = false;
                    }
                }
            }

            return randomArr;
        }
        static void True_fuction()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"     




                                                   True     ");
                Thread.Sleep(500);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void False_fuction()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"     




                                                   False     ");
                Thread.Sleep(500);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void trueORfalse(string ans,int first,int second,int third,int num)
        {
            if (ans == "a" || ans == "A")
            {
                if (TrueAnswers(num, Answer(num, first)))
                {
                    point += 10;
                    tA += 1;
                    True_fuction();

                }
                else
                {
                    if (point > 0)
                    {
                        point -= 10;
                    }
                    False_fuction();
                }
            }
            else if (ans == "b" || ans == "B")
            {
                if (TrueAnswers(num, Answer(num, second)))
                {
                    point += 10;
                    tA += 1;
                    True_fuction();
                }
                else
                {
                    if (point > 0)
                    {
                        point -= 10;
                    }
                    False_fuction();
                }
            }
            else if (ans == "c" || ans == "C")
            {
                if (TrueAnswers(num, Answer(num, third)))
                {
                    point += 10;
                    tA += 1;
                    True_fuction();
                }
                else
                {
                    if (point > 0)
                    {
                        point -= 10;
                    }
                    False_fuction();
                }
            }
            else
            {
                if (point > 0)
                {
                    point -= 10;
                }
                False_fuction();
            }
        }
        static void Start()
        {

            Question(1);
            Console.WriteLine();
            int first = getRandom()[0];
            int second = getRandom()[1];
            int third = getRandom()[2];
            Console.Write(" a) ");
            Answer(1,first);
            Console.Write(" b) ");
            Answer(1, second);
            Console.Write(" c) ");
            Answer(1, third);
            Console.WriteLine();
            Console.Write(" Answer : ");
            string ans = Console.ReadLine();
            trueORfalse(ans,first,second,third,1);

            Question(2);
            Console.WriteLine();
            //int first2 = getRandom()[0];
            //int second2 = getRandom()[1];
            //int third2 = getRandom()[2];
            Console.Write(" a) ");
            Answer(2, first);
            Console.Write(" b) ");
            Answer(2, second);
            Console.Write(" c) ");
            Answer(2, third);
            Console.WriteLine();
            Console.Write(" Answer : ");
            string ans2 = Console.ReadLine();
            trueORfalse(ans2, first, second, third,2);
            
            Question(3);
            Console.WriteLine();
            int first3 = getRandom()[0];
            int second3 = getRandom()[1];
            int third3 = getRandom()[2];
            Console.Write(" a) ");
            Answer(3, first3);
            Console.Write(" b) ");
            Answer(3, second3);
            Console.Write(" c) ");
            Answer(3, third3);
            Console.WriteLine();
            Console.Write(" Answer : ");
            string ans3 = Console.ReadLine();
            trueORfalse(ans3, first3, second3, third3,3);
            
            Question(4);
            Console.WriteLine();
            int first4 = getRandom()[0];
            int second4 = getRandom()[1];
            int third4 = getRandom()[2];
            Console.Write(" a) ");
            Answer(4, first4);
            Console.Write(" b) ");
            Answer(4, second4);
            Console.Write(" c) ");
            Answer(4, third4);
            Console.WriteLine();
            Console.Write(" Answer : ");
            string ans4 = Console.ReadLine();
            trueORfalse(ans4, first4, second4, third4,4);
            
            Question(5);
            Console.WriteLine();
            int first5 = getRandom()[0];
            int second5 = getRandom()[1];
            int third5 = getRandom()[2];
            Console.Write(" a) ");
            Answer(5, first5);
            Console.Write(" b) ");
            Answer(5, second5);
            Console.Write(" c) ");
            Answer(5, third5);
            Console.WriteLine();
            Console.Write(" Answer : ");
            string ans5 = Console.ReadLine();
            trueORfalse(ans5, first5, second5, third5,5);
            
            Question(6);
            Console.WriteLine();
            int first6 = getRandom()[0];
            int second6 = getRandom()[1];
            int third6 = getRandom()[2];
            Console.Write(" a) ");
            Answer(6, first6);
            Console.Write(" b) ");
            Answer(6, second6);
            Console.Write(" c) ");
            Answer(6, third6);
            Console.WriteLine();
            Console.Write(" Answer : ");
            string ans6 = Console.ReadLine();
            trueORfalse(ans6, first6, second6, third6,6);
            
            Question(7);
            Console.WriteLine();
            int first7 = getRandom()[0];
            int second7 = getRandom()[1];
            int third7 = getRandom()[2];
            Console.Write(" a) ");
            Answer(7, first7);
            Console.Write(" b) ");
            Answer(7, second7);
            Console.Write(" c) ");
            Answer(7, third7);
            Console.WriteLine();
            Console.Write(" Answer : ");
            string ans7 = Console.ReadLine();
            trueORfalse(ans7, first7, second7, third7,7);
            
            Question(8);
            Console.WriteLine();
            int first8 = getRandom()[0];
            int second8 = getRandom()[1];
            int third8 = getRandom()[2];
            Console.Write(" a) ");
            Answer(8, first8);
            Console.Write(" b) ");
            Answer(8, second8);
            Console.Write(" c) ");
            Answer(8, third8);
            Console.WriteLine();
            Console.Write(" Answer : ");
            string ans8 = Console.ReadLine();
            trueORfalse(ans8, first8, second8, third8,8);
            
            Question(9);
            Console.WriteLine();
            int first9 = getRandom()[0];
            int second9 = getRandom()[1];
            int third9 = getRandom()[2];
            Console.Write(" a) ");
            Answer(9, first9);
            Console.Write(" b) ");
            Answer(9, second9);
            Console.Write(" c) ");
            Answer(9, third9);
            Console.WriteLine();
            Console.Write(" Answer : ");
            string ans9 = Console.ReadLine();
            trueORfalse(ans9, first9, second9, third9,9);
            
            Question(10);
            Console.WriteLine();
            int first10 = getRandom()[0];
            int second10 = getRandom()[1];
            int third10 = getRandom()[2];
            Console.Write(" a) ");
            Answer(10, first10);
            Console.Write(" b) ");
            Answer(10, second10);
            Console.Write(" c) ");
            Answer(10, third10);
            Console.WriteLine();
            Console.Write(" Answer : ");
            string ans10 = Console.ReadLine();
            trueORfalse(ans10, first10, second10, third10,10);

            Console.WriteLine($" Your point : {point}");
            Console.WriteLine($" Your true answers : 10 / {tA}");

        }
        static void Main(string[] args)
        {
            Start();

        }
    }
}
