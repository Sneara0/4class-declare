using _4_class_declare.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_class_declare
{

    public class person
    {
        public string firtstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + firtstName +" " + lastName);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            person male = new person();
            male.firtstName = "sneara";
            male.lastName = "parvin";
            male.Introduce();


         var result=   calculator.Add(54, 76);
            Console.WriteLine(result);
            Console.ReadLine();






            
        }
    }
}
