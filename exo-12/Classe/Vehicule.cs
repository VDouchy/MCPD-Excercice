using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_12.Classe
{
    internal abstract class Vehicule
    {

        // Propriétés
        string Nom { get; set; }
        string Marque {  get; set; }


        // Constructeur

        public Vehicule(string nom, string marque)
        {
            Nom = nom;
            Marque = marque;
        }

        // Méthode

        public virtual string ToString()
        {
            return $"Le modèle de la voiture est {Nom} et de marque {Marque}";
        }




    }
}
