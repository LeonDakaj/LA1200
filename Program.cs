using System;

namespace Guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben sie eine Zahl zwischen 1-100 ein:");
            int attempts= 1;
            bool foward= false;
            int number= new Random().Next(1, 100);



            while (foward == false)
            {
                try
                {

                    int usernumber = Convert.ToInt32(Console.ReadLine());


                    if (number > usernumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Diese Zahl ist zu klein! Versuch grösser.");
                        Console.ForegroundColor = ConsoleColor.White;
                        attempts++;
                   

                    }
                    if (number < usernumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Diese Zahl ist zu gross! Versuch kleiner");
                        Console.ForegroundColor = ConsoleColor.White;
                        attempts++;
   
                    }
                    if (number == usernumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Bravo,du hast die richtige Zahl getroffen!");
                        Console.ForegroundColor = ConsoleColor.White;
                        attempts++;
                        Console.WriteLine("Du hattest " + attempts + " Versüche!");
                        foward = true;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Eine ZAHL! zwischen 1 und 100 eingeben:");
                    Console.ForegroundColor = ConsoleColor.White;
                }


            }


        }


    }
}

