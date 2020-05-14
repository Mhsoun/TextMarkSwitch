using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMarkSwitch
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your mark!");
            _ = float.TryParse(Console.ReadLine(), out float mark);

            switch (mark)
            {
                case float n when n > 0f && n <= 4f:
                    Console.WriteLine("Fail");
                    break;
                case 5:
                    Console.WriteLine("Pass");
                    break;
                case float n when n >= 6f && n < 7.8f:
                    Console.WriteLine("Good");
                    break;
                case float n when n >= 7.8f && n < 9.10f:
                    Console.WriteLine("Notable");
                    break;

                case float n when n <= 9.10f && n <= 100f:
                    Console.WriteLine("Excellent");
                    break;
                default:
                    Console.WriteLine("Value must be between 0 to 10");
                    break;
            }
        }
    }
}
