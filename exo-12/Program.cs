






using exo_12.Classe;
using exo_12.Interface;

Voiture v1 = new Voiture("108", "Peugeot");

VoitureHybride v2 = new VoitureHybride("Ion", "Peugeot");

Hydravion v3 = new Hydravion("Voisin Canard", "Peugeot");



//------------

v1.Demarrer();
Console.WriteLine(v1.ToString());
Console.WriteLine();
Console.WriteLine("------");

v2.Demarrer();
v2.Recharger();
Console.WriteLine(v2.ToString());
Console.WriteLine();

Console.WriteLine("------");

v3.Demarrer();
v3.Atterir();
v3.Decoller();
Console.WriteLine(v3.ToString());




