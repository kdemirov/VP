using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void pecati(double firstNumber,double secondNumber)
        {
            string userName;
            Console.WriteLine("Enter your name:");
            userName = Console.ReadLine();
            Console.WriteLine("Welcome {0}!", userName);
            Console.WriteLine("The sum of {0} and {1} is {2}.", firstNumber, secondNumber, firstNumber + secondNumber);
            Console.WriteLine("The result of subtracting {0} from {1} is {2}.", secondNumber, firstNumber, firstNumber - secondNumber);
            Console.WriteLine("The product of {0} and {1} is {2}.", firstNumber, secondNumber, firstNumber * secondNumber);
            Console.WriteLine("The result of dividing {0} by {1} is {2}.", firstNumber, secondNumber, firstNumber / secondNumber);
            Console.WriteLine("The remainder after dividing {0} by {1} is {2}.", firstNumber, secondNumber, firstNumber % secondNumber);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1.Slucajni broevi\n2.Vnesi Broevi");
            int izbor = Convert.ToInt32(Console.ReadLine());
            
            double firstNumber, secondNumber;
            Random random = new Random();
            if (izbor == 1)
            {
                
                
                
                Console.WriteLine("Now give me a number:");
                firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Now give me another number:");
                secondNumber = Convert.ToDouble(Console.ReadLine());
                pecati(firstNumber, secondNumber);
            }
            else if(izbor==2)
            {
                firstNumber = random.Next(1, 1000);
                secondNumber = random.Next(1, 1000);
                Console.WriteLine("Prviot slucaen generiran broj e {0}", firstNumber);
                Console.WriteLine("Vtoriot slucaen generiran broj e {0}", secondNumber);
                pecati(firstNumber, secondNumber);
            }
            Console.ReadKey();
        }
    }
}
