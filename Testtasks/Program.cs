using System;
using System.Collections.Generic;

namespace Testtasks
{
    class Program
    {
        //Funktsioon massiivide printimiseks
        private static void Print(int[] mass)
        {
            foreach (int i in mass)
                Console.Write(i);
            Console.WriteLine();
        }

        //Funktsioon massiivide printimiseks tagurpidi
        private static void Printrev(int[] mass)
        {
            for (int i = mass.Length-1;i>=0;i--)
                Console.Write($"{mass[i]}");
            Console.WriteLine();
        }

        //Funktsioon massiivide pööramiseks
        private static void Reverse(int[] mass)
        {
            for (int i=0; i<=mass.Length/2; i++)
            {
                int ajutine = mass[i];
                mass[i] = mass[mass.Length -1-i];
                mass[mass.Length - 1 - i] = ajutine;
            }
        }

        //Funktsioon 2D maatriksite elementide printimiseks
        private static void Printmatrix(int[][] matr)
        {
            for (int i = 0; i < matr[0].Length; i++)
            {
                for (int j = 0; j < matr[i].Length; j++)
                {
                    Console.Write(matr[i][j]);
                }
                Console.WriteLine();
            }
        }

        //Funktsioon 2D string maatriksite elementide printimiseks
        private static void Printsmatrix(string[,] smatr)
        {
            for (int i = 0; i < smatr.GetLength(0); i++)
            {
                for (int j = 0; j < smatr.GetLength(1); j++)
                {
                    Console.Write(smatr[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            

            Console.Clear();
            Console.WriteLine("Ahoi!");

            //Massiivi loomine ja selle tagurpidi printimine ja selle pööramine.
            int[] mass = new int[4] { 1, 2, 3, 4 };
            Console.WriteLine("Loodud massiiv:");
            Print(mass);
            Console.WriteLine("Massiivi tagurpidi printimine:");
            Printrev(mass);
            Console.WriteLine("Massiivi pööramine.");
            Reverse(mass);
            Print(mass);



            //2D maatriks, algväärtustamine ning printimine.
            int[][] matr;
            matr = new int[3][];
            matr[0] = new int[3] { 1, 2, 3 };
            matr[1] = new int[2] { 1, 2 };
            matr[2] = new int[4] { 1, 2, 3, 4 };

            string[,] smatr;
            smatr = new string[2, 3]
            {
                {"a","b","c" },
                {"d","e","f" }
            };

            Console.WriteLine("Prindin 2D maatriksi massiivide kaupa:");
            Printmatrix(matr);

            Console.WriteLine("Prindin string 2D maatriksi massiivide kaupa:");
            Printsmatrix(smatr);


            //Luua list, lasta kasutajal väärtused sisestada. Kui enam ei soovi, siis lasta sisestada tühi rida. Trükkida välja kõik väärtused, mis topelt.
            List<int> numbrid = new List<int>();
            bool go = true;
            while (go)
            {
                Console.WriteLine("Please enter a new value for the list and press ENTER: ");
                string userinput = Console.ReadLine();
                if (string.IsNullOrEmpty(userinput))
                {
                    go = false;
                    break;
                } 
                numbrid.Add(Int32.Parse(userinput));
                
            }
            if(!go && numbrid.Count == 0)
            {
                Console.WriteLine("Bye!");
            } else if (numbrid.Count > 0)
            {
                List<int> doubles = new List<int>();
                Console.WriteLine("Here are all the elements in the list: ");
                foreach (int num in numbrid)
                {
                    Console.WriteLine(num);
                    if (numbrid.IndexOf(num) != numbrid.LastIndexOf(num) && doubles.IndexOf(num) == -1)
                    {
                        doubles.Add(num);
                    }
                }
                if(doubles.Count >0)
                {
                    Console.WriteLine("Here are all the non-unique elements: ");
                    foreach (int d in doubles)
                    {
                        Console.WriteLine(d);
                    }
                } else
                {
                    Console.WriteLine("All the elements were unique.");
                }
                

                Console.WriteLine("Bye!");
            } else
            {
                Console.WriteLine("The list is empty.");
                Console.WriteLine("Bye!");
            }
        }

        
    }
}
