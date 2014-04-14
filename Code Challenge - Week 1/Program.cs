using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge___Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do FizzBuzz Loop 1=>20
            // Call FizzBuzz() for each number in the loop
            // End FizzBuzzLoop 1=>20

            // Do FizzBuzz Loop 92=>79
            // Call FizzBuzz() for each number in the loop
            // End FizzBuzzLoop 92=>79

            //Call Yodaizer Function
            Yodaizer("I like code");

            //Call TextStats Function
            TextStats("Coding is super fun and useful.  This function requires the use of arrays, loops, indexes, and if statements."  + 
                "There was a lot of thought that went into this code.");

            //Call IsPrime Function
            // Do IsPrime Loop 1=>25
            // Call IsPrime() for each number in the loop
            // End IsPrime Loop 1=>25

            //Call DashInsert Function
            DashInsert(8675309);

            //Console.ReadKey() to keep the console window open until we close it.
            Console.ReadKey();
        }

        //FizzBuzz Function
        static void FizzBuzz(int number)
        {
            //To Do: Fill in FizzBuzz Logic
        }

        //Yodaizer
        static void Yodaizer(string text)
        {
            //To Do: Fill in Yodaizer Logic
        }

        //Text Stats
        static void TextStats(string input)
        {
            //To Do: Fill in Text Stats Logic
        }

        //IsPrime
        static void IsPrime(int number)
        {
            //To Do: Fill in IsPrime Logic
        }

        //DashInsert
        static void DashInsert(int number)
        {
            //To Do: Fill in DashInsert Logic
        }

    }
}
