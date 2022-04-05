using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections;
using System.Linq;

namespace Puzzles
{
    class Program
    {
            public static Random random = new Random();
        public static List<string> Names()
        {
            List<string> names = new List<string> ();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charo");
            names.Add("Gene");
            names.Add("Sydney");
            var randomized = names.OrderBy(item => random.Next());
            foreach(string i in names)
            {
                if(i.Length >=5)
                {
                    Console.WriteLine(i);
                }
            }
            foreach(string i in randomized)
            {
                Console.WriteLine(i);
            }
            return(names);

        }


        public static string CoinToss()
        {
            string result= "";
            int randomBool = random.Next(2);
            // Console.Write("Tossing a coin!");
            if(randomBool == 1)
            {
                result = "Heads";
            }
            if (randomBool == 0)
            {
                result = "Tails";
            }
            Console.WriteLine(result);
            return(result);

        }
        public static void RandomArray()
        {
        int high = 0;
        int low = 25;
        int total = 0;
        List<int> randos = new List<int>();
        for( int i=0; i<=9; i++)
        {
            randos.Add(random.Next(5,25));
        }
        for (int i=0; i< randos.Count; i++)
        {
            if(randos[i]>high)
            {
                high = randos[i];
            }
            if(randos[i]< low)
            {
                low = randos[i];
            }
        }
        foreach(int val in randos)
        {
            total += val;
        }
        Console.WriteLine("The sum is:" + total.ToString());
        Console.WriteLine("The high is:" + high.ToString());
        Console.WriteLine( "The low is:" + low.ToString());
        }
        static void Main(string[] args)
        {
            Names();
            // RandomArray();
            Console.WriteLine(CoinToss());
    }
}}
