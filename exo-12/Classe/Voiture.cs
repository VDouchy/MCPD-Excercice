using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exo_12.Interface;

namespace exo_12.Classe
{
    internal class Voiture : Vehicule, IMotorise
    {


        string Nom { get; set; }
        string Marque { get; set; }


        // Constructeur

        public Voiture(string nom, string marque): base( nom,  marque) 
        {
            Nom = nom;
            Marque = marque;
        }


        // Méthodes

        public void Demarrer()
        {
            Console.WriteLine("la voiture démarre");
        }

        public virtual string ToString()
        {
            return $"Le modèle de la voiture est {Nom} et est de marque {Marque}";
        }


    }
}
