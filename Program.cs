namespace switchCase
{
    internal class Program
    {
        static void vowel()
        {
            Console.WriteLine("Please enter a letter to check if it is vowel or consonant:");
            char l = Convert.ToChar(Console.ReadLine());
            switch (l)
            {
                case 'a':
                    Console.WriteLine("This letter is Vowel");
                    break;
                case 'e':
                    Console.WriteLine("This letter is Vowel");
                    break;
                case 'i':
                    Console.WriteLine("This letter is Vowel");
                    break;
                case 'o':
                    Console.WriteLine("This letter is Vowel");
                    break;
                case 'u':
                    Console.WriteLine("This letter is Vowel");
                    break;
                default:
                    Console.WriteLine("This letter is Consonant");
                    break;

            }
        }
        static void month()
        {
            Console.WriteLine("Please enter a number to return the corresponding month:");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("This Month is January");
                    break;
                case 2:
                    Console.WriteLine("This Month is February");
                    break;
                case 3:
                    Console.WriteLine("This Month is March");
                    break;
                case 4:
                    Console.WriteLine("This Month is April");
                    break;
                case 5:
                    Console.WriteLine("This Month is May");
                    break;
                case 6:
                    Console.WriteLine("This Month is June");
                    break;
                case 7:
                    Console.WriteLine("This Month is July");
                    break;
                case 8:
                    Console.WriteLine("This Month is August");
                    break;
                case 9:
                    Console.WriteLine("This Month is September");
                    break;
                case 10:
                    Console.WriteLine("This Month is October");
                    break;
                case 11:
                    Console.WriteLine("This Month is November");
                    break;
                case 12:
                    Console.WriteLine("This Month is December");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Wrong Number! The number should be between 1 and 12");
                    Console.WriteLine();
                    month();
                    break;
            }

        }

        static void grade()
        {
            Console.WriteLine("Please enter a grade:");
            char l = Convert.ToChar(Console.ReadLine());
            switch (l)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Accepted");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Wrong letter!");
                    grade();
                    break;

            }
        }

        static void day()
        {
            Console.WriteLine("Please enter a number to get the corresponding day:");
            int d = Convert.ToInt32(Console.ReadLine()); ;
            switch (d)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Wrong Number!");
                    day();
                    break;
            }

        }
        static void Main(string[] args)
        {
            //  vowel();
            // month();
            //grade();
            day();

        }
    }
}


