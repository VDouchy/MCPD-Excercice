using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_18._1.Classe
{
    internal class Bibliotheque
    {
        // Attributs
        private List<Livre> _listLivres = new List<Livre>();


        // Propriétés

        public List<Livre> ListLivres { get { return _listLivres; } set { _listLivres = value; } }


        // Constructeur

        public Bibliotheque(List<Livre> livres) 
        {
            ListLivres = livres;

        }   

        // Méthodes

        public void AjouterLivre(Livre livre)
        {
            ListLivres.Add(livre);


        }


        public void SupprimerLivreParNum()
        {
            
           

        }

        public void AfficherAll(List<Livre> a)
        {
            Console.WriteLine(a);
        }

        /*
        public void RechercherLivreParTitre(string a)
        {
            
            
            foreach (string titreLivre in a)
            {
                if (titreLivre.Contains(a))
                {
                    Console.WriteLine(titreLivre);
                }
            }
            Console.WriteLine(a);
        }

        */











    }
}
