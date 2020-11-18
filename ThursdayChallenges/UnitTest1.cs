using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ThursdayChallenges
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NameAge()
        {
            string firstName = "Erika";
            string lastName = "Peltz";
            int age = 23;
        }

        [TestMethod]
        public void Array()
        {
            string[] stringArray = { "Scott Pilgrim", "Jarhead", "Midsommar", "Bojack Horseman" };
        }

        [TestMethod]
        public void Foreach()
        {
            string name = "Supercalifragilisticexpialidocious";
            foreach (char letter in name)

                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an I");
                }
        }

        [TestMethod]
        public void Operators()
        {
            int numOne = 23;
            int numTwo = 7;

            int sum = numOne + numTwo;
            { Console.WriteLine(sum); }
            int dif = numOne - numTwo;
            { Console.WriteLine(dif); }
            int prod = numOne * numTwo;
            { Console.WriteLine(prod); }
            int quot = numOne / numTwo;
            { Console.WriteLine(quot); }
            int remainder = numOne % numTwo;
            { Console.WriteLine(remainder); }

        }

        [TestMethod]
        public void SwitchCase()
        {
            string mood = "good";
            switch (mood)
            {
                case "great":
                    Console.WriteLine("That's Awesome!");
                    break;
                case "good":
                    Console.WriteLine("Neato!");
                    break;
                case "okay":
                    Console.WriteLine("Why not good?");
                    break;
                case "bad":
                    Console.WriteLine("Uh-Oh!");
                    break;
                case ":(":
                    Console.WriteLine(":'(");
                    break;
            }
        }
        [TestMethod]
        public void SleepChart()
        {
            int hours = 7;
            if (hours >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if (hours >= 8 && hours < 10)
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if (hours > 4 && hours < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, Get some sleep!");
            }
        }
        [TestMethod]
        public void RandomName()
        {
            List<DateTime> listOfDates = new List<DateTime>();
            DateTime today = DateTime.Now;
            listOfDates.Add(today);
            listOfDates.Add(new DateTime(2020, 12, 25));
            listOfDates.Add(new DateTime(1997, 04, 30));
            listOfDates.Add(new DateTime(1975, 09, 30));
        }
    }
}
    

