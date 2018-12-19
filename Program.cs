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
            // On demande le sexe
            Console.WriteLine("Bonjour, êtes-vous un homme ou une femme ?");
            string gender = (Console.ReadLine());
            // Puis l'age
            Console.WriteLine("Merci, quel est votre age ?");
            int age = int.Parse(Console.ReadLine());
            // Différentes conditions
            /*if (gender == "homme" && age >= 18 && age < 120) // homme majeur
            {
                Console.WriteLine("Vous êtes un homme et vous êtes majeur");
            }
            else if (gender == "homme" && age < 18 && age > 0) // homme mineur
            {
                Console.WriteLine("Vous êtes un homme et vous êtes mineur");
            }
            else if (gender == "femme" && age >= 18 && age < 120) // femme majeur
            {
                Console.WriteLine("Vous êtes une femme et vous êtes majeure");
            }
            else if (gender == "femme" && age< 18 && age> 0) // femme mineur
            {
                Console.WriteLine("Vous êtes une femme et vous êtes mineure");
            }
            else // si aucune des conditions précédentes ---> erreur
            {
                Console.WriteLine("Vous êtes particulier(ère), ou vous n'êtes pas humain(e) !");
            }*/


            if (gender == "femme")
            {
                if (age >= 18 && age < 120)
                {
                    Console.WriteLine("Vous êtes une femme et vous êtes majeure");
                }
                else if (gender == "femme" && age < 18 && age > 0)
                {
                    Console.WriteLine("Vous êtes une femme et vous êtes mineure");
                }
                else
                {
                    Console.WriteLine("Vous êtes particulière, ou vous n'êtes pas humaine ! \n Il doit y avoir un problème au niveau de l'age...");
                }
            }
            else if (gender == "homme")
            {
                if (age >= 18 && age < 120)
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes majeur");
                }
                else if (gender == "homme" && age < 18 && age > 0)
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes mineur");
                }
                else
                {
                    Console.WriteLine("Vous êtes particulier, ou vous n'êtes pas humain ! \n Il doit y avoir un problème au niveau de l'age...");
                }
            }
            else
            {
                Console.WriteLine("Vous êtes particulier(ère), ou vous n'êtes pas humain(e) ! \n Il doit y avoir un problème au niveau du genre...");
            }

        }
    }
}
