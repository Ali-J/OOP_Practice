using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RationalNumbers
{
    // Test class in order to see that the class being written is working
    class testRational
    {
        // "Main" entry point into program
        static void Main(string[] args)
        {
            // Create a new instance of the class Rational
            Rational Rational1 = new Rational();

            // In that class give two numbers (Numerator/Denominator) and send to the method "FindResult"
            Rational1.FindReducedForm(8, 12);
            // Write the values found to the screen
            Console.WriteLine(Rational1.RNum);
            Console.WriteLine(Rational1.RDen);
        }
    }

    // Create the class "Rational"
    public class Rational
    {
        // Delcare all variables to be used within class
        private int HCF;
        private int Divisor;

        public int RNum;
        public int RDen;

        // Create constructor which initialises all variables and creates
        // instance of class
        public Rational()
        {
            // Initialise RNum and RDen to 0 in order it will be known of they're not set
            RNum = 0;
            RDen = 0;
            // Set HCF to 1 in order that if no higher common factor is found, 1 is used
            // meaning the values cannot be reduced any further
            HCF = 1;
            // Start the divisor at 2 as this is the lowest useful point that can be started from
            Divisor = 2;
        }


        // Method within class designed to reduce values of ratio sent and return result
        // to the screen
        public int FindReducedForm(int Num, int Den)
        {
            // Assign values recieved from method call to variables declared within class
            RNum = Num;
            RDen = Den;

            // Find highest common factor for numerator and denominator
            while (Divisor <= RNum)
            {
                // Find values with remainder 0 when dividing numerator and denominator by divisor
                if (((RNum % Divisor) == 0) & ((RDen % Divisor) == 0))
                {
                   HCF = Divisor;
                }
                else
                    Divisor++;
            }

            // Reduce value in order that most reduced form is written to screen.
            RNum = Num/Divisor;
            RDen = Den/Divisor;

            return RDen;

        }
    }
}
