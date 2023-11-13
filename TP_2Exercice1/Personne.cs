using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2Exercice1
{
    internal class Personne
    {
        private string nom;
        private string prenom;
        private int age;
        public Personne()
        { 
           this.nom = string.Empty;
           this.prenom = string.Empty;
           this.age = 0;
        }
        public Personne(String nom, String prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }
        public Personne(Personne personne)
        {
            this.nom = personne.nom;
            this.prenom = personne.prenom;
            this.age = personne.age;
        }
        public void setNom(String nom)
        {
            this.nom = nom;
        }
        public void setPrenom(String prenom)
        {
            this.prenom = prenom;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public String getNom()
        {
            return this.nom;
        }
        public string getPrenom()
        {
            return this.prenom;
        }
        public int getAge()
        {
            return this.age;
        }

        public void getInfo()
        {
            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("-Nom : \t" + getNom() + " -Prénom : \t" + getPrenom() + " -Age : \t" + getAge());
            Console.WriteLine("*******************************************************************************************************");
        }
    }
}
