using System;
using System.Reflection.PortableExecutable;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Machine(); 
                
        }

        static void Machine()
        {
            int inMachine = 0;
            string decision = "000";
            while (decision[0] != '1')

            decision = insertion(inMachine);

            Console.WriteLine("Dispensing merchandise...");
            if (decision[1] == '0' && decision[2] == '0')
                Console.WriteLine("No need to return change.");
            else
            {
                if (decision[1] == '1')
                    Console.WriteLine("Returning a nickel.");
                if (decision[2] == '1')
                    Console.WriteLine("Returning a dime.");
            }
        }

        static string insertion(int inMachine)
        {
            string inserted;
            while (inMachine < 20)
            {
                Console.WriteLine("Insert your coin: ");
                inserted = Console.ReadLine();
                if (inserted == "Dime" || inserted == "dime" || inserted == "DIME")
                    inMachine += 10;
                if (inserted == "Nickel" || inserted == "nickel" || inserted == "NICKEL")
                    inMachine += 5;
                if (inserted == "Quarter" || inserted == "quarter" || inserted == "QUARTER")
                    inMachine += 20;
            }
            if (inMachine > 30)
                return "111";
            else if (inMachine == 30)
                return "101";
            else if (inMachine > 20)
                return "110";
            else return "100";
        }
    }
}