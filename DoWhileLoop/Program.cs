using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Learning Do While Loop
            

            // Example #1 
            //This is where the condition is false so hello will be only print once
            var i = 0;
            do
            {
                Console.WriteLine("Hello");
                i++;
            } while (i > 5);
            Console.WriteLine();

            //Example #2 
            // This will print 5 to 1 
            var m = 5;
            do
            {
                Console.WriteLine(m);
                m--;
            } while (m > 0);
            Console.WriteLine();


            //Example #3 
            //Print 3 to 0
            int n = 3;
            do
            {
                Console.WriteLine(n);
                n--;
            } while (n >= 0);
            Console.WriteLine();


            //Example #4
            int h = 7;
            do
            {
                Console.WriteLine("Done learning DO WHILE loop");
                h--;
            } while (h >= 5);

        }
       
    }
}
