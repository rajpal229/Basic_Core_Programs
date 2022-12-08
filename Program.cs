namespace Basic_Core_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Flag = true;
            while (Flag)
            {
                Console.WriteLine("Enter:\n 1. Flip Coin \n 2. Leap Year\n3. Power of 2\n4. Harmonic Number");
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
                    default:
                        Console.WriteLine("Enter Valid Number");
                        break;
                }
            }
        }
    }
}