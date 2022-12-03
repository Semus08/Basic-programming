using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_of_code
{
    public class basicCode
    {
        private float xy;

        public void Strings()
        {
            string Broertje = "Roan";
            Console.WriteLine(Broertje);

        }
        public void Intergers()
        {
            //add 2 whole numbers and print it to the console
            int x = 7, y = 69;
            Console.WriteLine(x + y);
        }
        public void Floats()
        {
            //divide 2 fractional numbers and send it to the console
            float  x = 9.7f, y = 2.8f;
            Console.WriteLine(x / y);

            
        }
        public void Bools()
        {

        }
        public void Loops()
        {
            string roan;
            int x = 8, y = 6;
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
