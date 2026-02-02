
using Exo_14.Enum;
using Exo_14.Classes;





Console.WriteLine(" EXPEDITEUR: Renseignez votre Nom, Prénom, et Adresse: ");


string nomInputex = Console.ReadLine();
string prenomInputex = Console.ReadLine();
int numeroRueex = int.Parse(Console.ReadLine());
string nomRueex = Console.ReadLine();
string villeex = Console.ReadLine();
string cpex = Console.ReadLine();


User expediteur1 = new User(nomInputex, prenomInputex, new Adresse(numeroRueex, nomRueex, villeex, cpex));

Console.WriteLine($"L'adresse de l'expéditeur est: {expediteur1.ToString()}");


Console.WriteLine(" DESTINATAIRE: Renseignez le Nom, Prénom, et Adresse du destinataire: ");


string nomInputDes = Console.ReadLine();
string prenomInputDes = Console.ReadLine();
int numeroRueDes = int.Parse(Console.ReadLine());
string nomRueDes = Console.ReadLine();
string villeDes = Console.ReadLine();
string cpDes = Console.ReadLine();


User destinataire1 = new User(nomInputDes, prenomInputDes, new Adresse(numeroRueDes, nomRueDes, villeDes, cpDes));

Console.WriteLine($"L'adresse du destinataire est: {destinataire1.ToString()}");

//----------
Console.WriteLine(" Rédigez voter lettre: ");

string contenuLettre = Console.ReadLine();


Lettre lettre1 = new Lettre(expediteur1, destinataire1, contenuLettre, StatutLettreEnum.ENATTENTE);


Console.WriteLine("-----------------------------------");
Console.WriteLine("-----------------------------------");
Console.WriteLine(" Voulez-vous envoyer votre lettre ? ");
string userInput = Console.ReadLine();
if(userInput == "y")
{
    lettre1.Envoyer();
}

Console.WriteLine("-----------------------------------");
Console.WriteLine("-----------------------------------");

Console.WriteLine(" Toutes les infos de votre lettre: ");


Console.WriteLine("-----------------------------------");
Console.WriteLine(lettre1);






