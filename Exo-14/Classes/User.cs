using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_14.Classes
{
    internal class User
    {

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Adresse Adresse { get; set; }

       


        // Constructeur

        public User(string nom, string prenom, Adresse adresse)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
        }


        // Méthode

        public override string ToString() 
        {
            return $"Le nom est: {Nom}, son prenom est {Prenom} et l'adresse est: {Adresse}";
        }





    }
}
