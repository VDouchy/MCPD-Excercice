using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_18._1.Classe
{
    internal class Livre
    {



        // Attributs
        private int _numero;
        private string _titre;
        private string _auteur;
        private int _numeroExemplaireDispo;


        // Propriétés

        public int Numero { get { return _numero; } set { _numero = value; } }
        public string Titre { get { return _titre; } set { _titre = value; } }
        public string Auteur { get { return _auteur; }set {  _auteur = value; } }

        public int NumeroExemplaireDispo { get { return _numeroExemplaireDispo; } set { _numeroExemplaireDispo = value; } }

            
                // Constructeur

                public Livre(int numero, string titre, string auteur, int numeroExDispo)
                {
                    Numero = numero;
                    Titre = titre;
                    Auteur = auteur;
                    NumeroExemplaireDispo = numeroExDispo;

                }

        }
    }
