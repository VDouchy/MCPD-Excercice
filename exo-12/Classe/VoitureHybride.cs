using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exo_12.Interface;

namespace exo_12.Classe
{
    internal class VoitureHybride : Vehicule, IMotorise, IElectrique
    {
        string Nom { get; set; }
        string Marque { get; set; }


        // Constructeur

        public VoitureHybride(string nom, string marque) : base(nom, marque)
        {
            Nom = nom;
            Marque = marque;
        }

        // Méthode

        public void Demarrer()
        {
            Console.WriteLine("La Voiture Hybride démarre");
        }

        public void Recharger()
        {
            Console.WriteLine("La Voiture Hybride se recharge");
        }



        public virtual string ToString()
        {
            return $"Le modèle de la voiture Hybride est {Nom} et est de marque {Marque}";
        }





    }
}
