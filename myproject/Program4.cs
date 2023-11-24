using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld {
class Program4 {
            
    static void Main(string[]args) {

        string name = "John";        

        Console.WriteLine(name);
        Console.WriteLine("The lenght of the variable name is {0}", name.Length);
        Console.WriteLine("The uppercase version of the variable name is :{0}", name.ToUpper());
        Console.WriteLine("The lowercase version of the variable name is :{0}",name.ToLower());
        Console.WriteLine("The sub string version of the variable name is :{0}", name.Substring(2));
        Console.WriteLine("The reverse version of the variable name is : {0}", name.Reverse().ToArray());


        Console.ReadKey(); 

    }
}
}