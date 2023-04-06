using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemo276Batch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 276Batch");
            Console.WriteLine("Code pushing from 2nd Develeoper");
            Console.WriteLine("Modifying code from remote repository");
            Console.WriteLine("Modifying in local repository");
            
            //object or instance syntax
            //ClassName variable=new ClassName();
            Human human = new Human();
            //display msg on output screen
            Console.WriteLine("Please enter human name");
            //reading input from output screen
            human.name = Console.ReadLine();
            Console.WriteLine("Please enter your height");
            human.height = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter your weight");
            human.weight = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter your age");
            human.age = Convert.ToInt32(Console.ReadLine());
            human.Speek();
            human.HumanDetails(human.name, human.height, human.weight, human.age);
            Console.ReadLine();
        }
    }
}
