namespace Basic_Core_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Flag = true;
            while (Flag)
            {
                Console.WriteLine("Enter:\n 1. Flip Coin \n 2. Leap Year\n3. Power of 2");
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
                    case 3:
                        PowerOfTwo powerofTwo = new PowerOfTwo();
                        powerofTwo.powerofTwo();
                        break;
                    default:
                        Console.WriteLine("Enter Valid Number");
                        break;
                }
            }
        }
    }
}