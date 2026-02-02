using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exo_14.Enum;

namespace Exo_14.Classes
{
    internal class Lettre
    {

        public User Expediteur { get; set; }
        public User Destinataire { get; set; }
        public string Contenu { get; set; }
        public StatutLettreEnum Statut { get; set; }


        // Constructeur

        public Lettre(User expediteur, User destinataire, string contenu, StatutLettreEnum statut)
        {
            Expediteur = expediteur;
            Destinataire = destinataire;
            Contenu = contenu;
            Statut = statut;

        }


        // Méthode

        
        public void Envoyer()
        {
            Statut = StatutLettreEnum.ENVOYEE;

        }

        public void Lire()
        {
            Statut = StatutLettreEnum.LUE;
        }

        public override string ToString() 
        {
            return $"L'expediteur de la lettre est {Expediteur}, elle est reçue par {Destinataire}. Le statut de la lettre est {Statut} et son contenue est : {Contenu}";
        }






    }
}
