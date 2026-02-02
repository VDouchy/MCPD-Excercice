using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_14.Classes
{
    internal class Adresse
    {


        public int NumeroRue {  get; set; }
        public string NomRue { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }


        // Constructeur

        public Adresse(int numRue, string nomRue, string ville, string cp)
        {
            NumeroRue = numRue;
            NomRue = nomRue;
            Ville = ville;
            CodePostal = cp;
        }


        // Méthode


        public override string ToString() 
        {
            return $"N° {NumeroRue},{NomRue},{Ville},{CodePostal}";
        }






    }
}
