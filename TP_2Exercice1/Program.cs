using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2Exercice1
{
    internal class Program
    {
           
        static void Main(string[] args)
        {
                Console.WriteLine("Création d'objet article par argument : \n");

                Article article1 = new Article("toto","reference De Toto",1653);

                article1.affiche();
                Console.WriteLine("\n");
                Console.WriteLine("Clicker sur qlq chose pour quitter !!");
                Console.ReadLine();

            Console.WriteLine("Création d'objet Personne par argument : \n");

        }
    }
}
