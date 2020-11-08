using System;
using System.Collections.Generic;

namespace Testtasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello!");
            //Luua N elemendiga massiiv ning trükkida see välja. Vahetada massiivi väärtuste järjekord vastupidiseks Reverse() funtsiooni kasutamata. Trükkida tulemus
            int[] mass = {1,2,3};
            Console.WriteLine("These are all the elements in mass array: ");
            foreach (int i in mass)
            {
                Console.WriteLine(i);
            }
            int[] massrev = new int[3];
            int index = 0;
            for (int i = mass.Length-1; i >= 0; i--)
            {
                massrev[index] = mass[i];
                index++;
            }
            Console.WriteLine("These are all the elements in mass array in reverse order: ");
            foreach(int r in massrev)
            {
                Console.WriteLine(r);
            }

            //Luua 2D maatriks, algväärtustada see ning trükkida kõik väärtused välja ridade kaupa (iga väärtus eraldi väljundi real)
            int[][] matr;
            matr = new int[3][];
            matr[0] = new int[3] { 1, 2, 3 };
            matr[1] = new int[2] { 1, 2 };
            matr[2] = new int[4] { 1, 2, 3, 4 };
            for (int i=0;i<matr[0].Length;i++)
            {
                Console.WriteLine("These are the elements of the {0}. subarray:",(i+1));
                for(int j = 0; j < matr[i].Length; j++)
                {
                    Console.WriteLine(matr[i][j]);
                }   
            }

            string[,] smatr;
            smatr = new string[2, 3]
            {
                {"a","b","c" },
                {"d","e","f" }
            };
            for (int i = 0; i < smatr.GetLength(0); i++)
            {
                Console.WriteLine("These are the elements of the {0}. subarray of the string matrix:",(i+1));
                for (int j=0;j<smatr.GetLength(1);j++)
                {
                    Console.WriteLine(smatr[i,j]);
                }
            }

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
