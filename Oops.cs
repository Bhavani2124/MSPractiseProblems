using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftProblems
{
    internal class Oops
    {

        public abstract class ComplexNumbers
        {
            // Complete this class
            private int real;
            private int imag;

            public abstract void randomMethod();
            public ComplexNumbers(int real, int imag)
            {
                this.real = real;
                this.imag = imag;
            }
            public void print()
            {
                Console.WriteLine(real + "+i" + imag);
            }

            public void plus(ComplexNumbers c2)
            {
                this.real = this.real + c2.real;
                this.imag = this.imag + c2.imag;

            }

            public void multiply(ComplexNumbers c2)
            {
                this.real = (this.imag * c2.imag) - this.real * c2.real;
                this.imag = (this.real * c2.imag) + (this.imag * c2.real);
            }
        }




        //public static void SMain(String[] args)
        //{

        //    int real1 = 4;
        //    int imaginary1 = 5;

        //    int real2 = 6;
        //    int imaginary2 = 7;

        //    //ComplexNumbers c1 = new ComplexNumbers(real1, imaginary1);
        //    //ComplexNumbers c2 = new ComplexNumbers(real2, imaginary2);

        //    int choice = 1;


        //    if (choice == 1)
        //    {
        //        // Add

        //        c1.plus(c2);
        //        c1.print();
        //    }
        //    else if (choice == 2)
        //    {
        //        // Multiply
        //        c1.multiply(c2);
        //        c1.print();
        //    }
        //    else
        //    {
        //        return;
        //    }
        //}
    }
}
