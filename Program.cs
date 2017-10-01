using System;
using System.Collections.Generic;
using System.Linq;
namespace puzzles_NEW
{
    class Program
    {
        public  static int[] randomArray()
        {
            // Random rand = new Random();
            // int max = 0;
            // int min = 0;
            // int sum = 0;
            // for(int i = 1; i < 10; i++)
            // {
            //     int var = (rand.Next(5,26));
            //     if(i > max)
            //     {
            //         max = i;
            //     }
            //     if(i < min)
            //     {
            //         min = i;
            //     }
            //     sum += var[i];
                
            // }
            // return 
            Random rand = new Random();
            int[] somethingArray = new int[10];
            int sum = 0;
            for (int i = 0; i < somethingArray.Length; i++)
            {
                int value = rand.Next(5,26);
                somethingArray[i] = value;
                sum += somethingArray[i];
            }
            Console.WriteLine("the max is: {0}", somethingArray.Max());
            Console.WriteLine("the min is: {0}", somethingArray.Min());
            Console.WriteLine("the sum is: {0}", sum);
            return somethingArray;
        }

        public static void tossCoin()
        {
            Console.WriteLine("Tossing the coin....");
            Random rand = new Random();
            int variable = rand.Next(1,3);
            int result = variable;
            //if odd(tails)
            if(variable == 1)
            {
                Console.WriteLine("its tails");
            }
            //if even(heads)
            if (variable == 2)
            {
                Console.WriteLine("its heads!");
            }
            
           // Console.WriteLine(result);
        }

        public static string[] names()
        {
            string[] nameArr = new string[5]{"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random rand = new Random();
            for (int i = 0; i < nameArr.Length - 1; i++)
            {
                int randomOrder = rand.Next(i + 1, nameArr.Length - 1);
                string temp = nameArr[i];
                nameArr[i] = nameArr[randomOrder];
                nameArr[randomOrder] = temp;
                Console.WriteLine(nameArr[i]);
            }

            List<string> namesLength = new List<string>();
            foreach(var name in namesLength)
            {
                namesLength.Add(name);
            }
            return namesLength.ToArray();
        }
        public static void Main(string[] args)
        {
            randomArray();
            tossCoin();
            names();
            
            //Console.WriteLine("Hello World!");
        }
    }
}
