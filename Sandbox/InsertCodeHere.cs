using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line


            // Case 1
            Console.WriteLine("Start of case 1");   // 0 3 6 9 12
            for (int i = 0; i < 15; i = i + 3)
            {
                Console.WriteLine(i); // Uncomment to see result
            }
            Console.WriteLine("End of case 1");


            // Case 2
            Console.WriteLine("Start of case 2");       // 10 9 8 7 6 5 4 3
            for (int i = 10; i >= 3; i--)
            {
                Console.WriteLine(i); // Uncomment to see result
            }
            Console.WriteLine("End of case 2");


            // Case 3 - Change this to a for-loop!
            Console.WriteLine("Start of case 3");
            
            for (int c3 = 0; c3 < 12; c3 += 2)
                Console.WriteLine(c3);
            /*  while (c3 < 12)
            {
                c3 = c3 + 2;    
                Console.WriteLine(c3);  */
            //}
            Console.WriteLine("End of case 3");


            // Case 4 - Change this to a for-loop!
            Console.WriteLine("Start of case 4");

            for (int c4 = 0; c4 < 50; c4 = c4 * 2 + 2)
                Console.WriteLine(c4);

          /*  int c4 = 0;
            while (c4 < 50)
            {
                Console.WriteLine(c4);
                c4 = c4 * 2 + 2;
            }   */
            Console.WriteLine("End of case 4");

            // The LAST line of code should be ABOVE this line
        }
    }
}
