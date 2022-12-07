﻿namespace Basic_Core_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Flag = true;
            while (Flag)
            {
                Console.WriteLine("Enter:\n 1. Flip Coin \n 2. Leap Year");
                int Option = Convert.ToInt32(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.checkFlipCoin();
                        break;
                    case 2:
                        LeapYear leapYear = new LeapYear();
                        leapYear.checkLeapYear();
                        break;
                    default:
                        Console.WriteLine("Enter Valid Number");
                        break;
                }
            }
        }
    }
}