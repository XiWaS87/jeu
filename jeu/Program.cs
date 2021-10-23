using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration 
            int valeur = 0;
            int essai;
            int nbre = 1;
            nbre = nbre++;
            bool erreur = true;
            while (erreur)
            {
                try
                {
                    Console.Write("Entrez le nombre à chercher = ");
                    valeur = int.Parse(Console.ReadLine());
                    erreur = false;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez une nombre entier");
                }
            }
            Console.Clear();
            // saisie du premier essai 
            Console.Write("Entrez un essai = ");
            essai = int.Parse(Console.ReadLine());
            // test de l'essai par rapport à la valeur à chercher 
            while (essai != valeur)
            {
                if (essai > valeur)
                {
                    Console.WriteLine(" --> trop grand !");
                }
                else
                {
                    Console.WriteLine(" --> trop petit !");
                }
                Console.Write("Entrez un essai = ");
                essai = int.Parse(Console.ReadLine());
                nbre++;
            }
            Console.WriteLine("Vous avez trouvé en " + nbre + " fois !");
            Console.ReadLine();
        }
    }
}
