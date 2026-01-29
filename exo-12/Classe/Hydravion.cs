using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exo_12.Interface;

namespace exo_12.Classe
{
    internal class Hydravion : Vehicule, IMotorise, IVolant, IFlottant
    {


        string Nom { get; set; }
        string Marque { get; set; }

        public Hydravion(string nom, string marque) : base(nom, marque)
        {
            Nom = nom;
            Marque = marque;
        }

        // Méthode

        public void Atterir()
        {
            Console.WriteLine("L'hydravion atterit");
        }

        public void Decoller()
        {
            Console.WriteLine("L'hydravion décolle");
        }

        public void Demarrer()
        {
            Console.WriteLine("L'hydravion démarre");
        }

        public void Naiguer()
        {
            Console.WriteLine("L'hydravion navigue");
        }



        public virtual string ToString()
        {
            return $"Le modèle de l'hydravion est {Nom} et est de marque {Marque}";
        }









    }
}
