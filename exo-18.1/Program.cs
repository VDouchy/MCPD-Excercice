



using System.Collections.Generic;
using exo_18._1.Classe;


List<Livre>listLivres = new List<Livre>();


Bibliotheque bibliotheque1 = new Bibliotheque(listLivres);


Livre livre1 = new Livre(1, "The witcher", "Andrej Sapwoski", 10);


Livre livre2 = new Livre(2, "Titeuf", "zep", 0);


Livre livre3 = new Livre(1, "Une poignée d'étoile", "Rafik Schami", 7);




bibliotheque1.AjouterLivre(livre1);
bibliotheque1.AjouterLivre(livre2);
bibliotheque1.AjouterLivre(livre3);
Console.WriteLine("titre du livre 1");
Console.WriteLine(livre1.Titre);



Console.WriteLine("tout leslivre");
foreach (Livre livre in listLivres)
{
    Console.WriteLine(livre.Titre);
}



























