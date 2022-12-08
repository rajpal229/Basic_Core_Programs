namespace Basic_Core_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Flag = true;
            while (Flag)
            {
                Console.WriteLine("Enter:\n 1. Flip Coin \n 2. Leap Year\n3. Power of 2\n" +
                    "4. Harmonic Number\n5.Prime Number\n6.Quotient Reminder\n7. Swap Numbers");
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
                    case 4:
                        HarmonicNumber harmonicNumber = new HarmonicNumber();
                        harmonicNumber.nthHarmonicNumber();
                        break;
                    case 5:
                        PrimeFactors factors = new PrimeFactors();
                        factors.Prime_Factors();
                        break;
                    case 6:
                        QuotientReminder quotientReminder = new QuotientReminder();
                        quotientReminder.ComputeQuotientReminder();
                        break;
                    case 7:
                        SwapNumbers swap_Numbers = new SwapNumbers();
                        swap_Numbers.SwapTwoNumbers();
                        break;
                    default:
                        Console.WriteLine("Enter Valid Number");
                        break;
                }
            }
        }
    }
}