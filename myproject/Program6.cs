using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions {
    class Program {
        static void Main(string[]args) {

        Console.WriteLine("Enter the first number : ");
        String num1Value = Console.ReadLine();

        int num1 = Convert.ToInt32(num1Value);

        Console.WriteLine("Enter the second number : ");
        String num2Value = Console.ReadLine();

        int num2 = Convert.ToInt32(num2Value);

        if (num1 < num2)
        {
            Console.WriteLine("Number 1 is lower than Number2");
        }
        else if (num1 > num2)
        {
            Console.WriteLine("Number 1 is bigger than Number2");
        }
        else{
            Console.WriteLine("Number 1 is equal to Number2");
        }
        Console.ReadKey();
    }
}
}
