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
			// Create a new instance of the class MenuOption for user input
			MenuOption MenuOption1 = new MenuOption();
			
			// Call GetInput function in order to get inputs to be reduced
			MenuOption1.GetInput();
			
            // Create a new instance of the class Rational
            Rational Rational1 = new Rational();
			
			// Send numbers to reduced form function. 
            Rational1.FindReducedForm(MenuOption1.InptNum, MenuOption1.InptDen);
			
            // Write the values found to the screen
            Console.WriteLine(Rational1.RNum);
            Console.WriteLine(Rational1.RDen);
        }
    }
	
	// Declare class to give user option to reduce fraction and enter variables to be reduced
	class MenuOption
	{
		// Delcare private integers to be used to take user input for fractions before sending to reduction function
		public int InptNum;
		public int InptDen;
		
		// Constructor for menu option variables
		public MenuOption()
		{		
			InptNum = 0;
			InptDen = 0;
		}
		
		// Function call to get fraction to be reduced
		public int GetInput()
		{
			// Get two numbers (Numerator/Denominator) from user input
			Console.WriteLine("Please enter a Numerator");
			InptNum = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter a Denominator");
			InptDen = Convert.ToInt32(Console.ReadLine());
			
			return InptDen;
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
			
			// Debug Write the values to the screen to check function has been called correctly
			///Console.WriteLine("DEBUG: Check that values are sent to function correctly");
            ///Console.WriteLine(RNum);
            ///Console.WriteLine(RDen);

            // Find highest common factor for numerator and denominator
            while (Divisor <= RNum)
            {
				// Debug Write the values to the screen to check function has been called correctly
				///Console.WriteLine("DEBUG: Check that loop is executing correctly");
	            ///Console.WriteLine(Divisor);
	            ///Console.WriteLine(RNum);
				
                // Find values with remainder 0 when dividing numerator and denominator by divisor
                if (((RNum % Divisor) == 0) & ((RDen % Divisor) == 0))
                {
                  	HCF = Divisor;
					Divisor++;
                }
                else
                    Divisor++;
			// Debug Write the found values to the screen to check function has been executed correctly
			///Console.WriteLine("DEBUG: Check that HCF is calculated in loop correctly");
            ///Console.WriteLine(HCF);
            }

            // Reduce value in order that most reduced form is written to screen.
            RNum = Num/HCF;
            RDen = Den/HCF;
			
			// Debug Write the found values to the screen to check function has been executed correctly
			///Console.WriteLine("DEBUG: Check that values are calculated in function correctly");
            ///Console.WriteLine(RNum);
            ///Console.WriteLine(RDen);
			
            return RNum;

        }
    }
}
