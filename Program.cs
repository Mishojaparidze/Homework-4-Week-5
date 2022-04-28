using System;

namespace Homework_4_Week_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion1

            //Solution1
            Console.WriteLine("Solution1");
            Console.WriteLine("Enter number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            int reminder = number %= 5;
            if (reminder == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            #endregion

            #region MyRegion2
            //Solution2
            Console.WriteLine("Solution2");
            Console.WriteLine("Enter number1 : ");
            Console.WriteLine("Enter number2 : ");
            var x = Convert.ToInt32(Console.ReadLine());
            var y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x+y);
            if (x > y)
            {
                Console.WriteLine(x - y);
            }
            else
            {
            Console.WriteLine(y - x); }
            Console.WriteLine(x*y);
            
            if (x > y)
            {
                if(y!=0)
                    {
                    Console.WriteLine(x / y);
                    }
                else { Console.WriteLine("Not Allowed To Divide By Zero"); }
            }
            else
            {
                if (x != 0)
                {
                    Console.WriteLine(y / x);
                }
                else { Console.WriteLine("Not Allowed To Divide By Zero"); }
            }
            #endregion

            #region MyRegion3
            //Solution3
            Console.WriteLine("Solution3");
            Console.WriteLine("Enter a : ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b : ");
            var b = Convert.ToInt32(Console.ReadLine());
            int c;
            Console.WriteLine("Your entered number");
            Console.WriteLine($"a= {a}");
            Console.WriteLine($"b= {b}");
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Returned number");
            Console.WriteLine($"a= {a}");
            Console.WriteLine($"b= {b}");



            #endregion

            #region MyRegion4
            //Solution4
            Console.WriteLine("Solution4");

            Console.WriteLine("Enter your number : ");

            var yourNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(yourNumber*i);
            }
            #endregion

            #region MyRegion5
            //Solution5
            Console.WriteLine("Solution5");
            Console.WriteLine("Enter N number : ");
            var n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                if (i > 0&i % 2 == 0)
                {
                Console.WriteLine(i * i);
            }

        }


        #endregion



    }
}

}