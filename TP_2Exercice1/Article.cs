using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2Exercice1
{
    internal class Article
    {
        private string nom;
        private string reference;
        private double prixUnitaire;
        public Article()
        { }
        public Article(String nom, String reference, double prixUnitaire)
        {
            this.nom = nom;
            this.reference = reference;
            this.prixUnitaire = prixUnitaire;
        }
        public Article(Article article)
        {
            this.nom = article.nom;
        }
        public void setNom(String nom)
        {
            this.nom = nom;
        }
        public void setRef(String reference)
        {
            this.reference = reference;
        }
        public void setPrix(double prix)
        {
            this.prixUnitaire = prix;
        }
        public String getNom()
        {
            return this.nom;
        }
        public string getReference()
        {
            return this.reference;
        }
        public double getPrixUnitaire()
        {
            return this.prixUnitaire;
        }

        public void affiche()
        {
            Console.WriteLine("µµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµ");
            Console.WriteLine("-Nom : \t" + getNom() + " -Référence : \t" + getReference() + " -Prix Unitaire : \t" + getPrixUnitaire());
            Console.WriteLine("µµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµµ");
        }
    }
}

