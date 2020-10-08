using System;

namespace DecisionMakingDemo
{
    class DecisionMaking
    {
        static void Main(string[] args)
        {
            int x = 10, y = 0, z = -20;
            Console.WriteLine("{0}, {1}, {2}", MyAbs(x), MyAbs(y), MyAbs(z));

            Grade('A');
            Grade('B');
            Grade('C');
            Grade('D');
            Grade('E');
            Grade('F');

            NestedSwitchDemo();
        }

        static void NestedSwitchDemo()
        {
            int a = 100, b = 200;

            switch (a) 
            {
                case 100:
                    Console.WriteLine("This is part of the outer switch");

                    switch (b)
                    {
                        case 200:
                            Console.WriteLine("This is part of the inner switch");
                            break;
                    }
                    break;
            }
        }

        static int MyAbs(int x)
        {
            if (x < 0)
            {
                return -x;
            }
            else if (x == 0)
            {
                return 0;
            }
            else
            {
                return x;
            }
        }

        static void Grade(char grade)
        {
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("Not bad");
                    break;
                case 'C':
                    Console.WriteLine("Must improve");
                    break;
                case 'D':
                    Console.WriteLine("Bad");
                    break;
                case 'E':
                    Console.WriteLine("Terrible!");
                    break;
                default:
                    Console.WriteLine("Failed!");
                    break;
            }
        }
    }
}