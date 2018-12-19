using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, êtes-vous un homme ou une femme ?");
            string gender = (Console.ReadLine());

            Console.WriteLine("Merci, quel est votre age ?");
            int age = int.Parse(Console.ReadLine());

            if (gender == "homme" && age >= 18) Console.WriteLine("Vous êtes un homme et vous êtes majeur");
            else if (gender == "homme" && age < 18) Console.WriteLine("Vous êtes un homme et vous êtes mineur");
            else if (gender == "femme" && age >= 18) Console.WriteLine("Vous êtes une femme et vous êtes majeur");
            else Console.WriteLine("Vous êtes une femme et vous êtes mineur");

        }
    }
}
