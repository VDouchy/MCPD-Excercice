



using System.Runtime.InteropServices;
using exo_.Classe;

double [] tabDeNotes = {};

//-------------------------


double CalculMoyenne(double[] a)
{
    if (a.Length == 0)
    {
        throw new InvalidArrayException("Le tableau de notes ne peut pas être vide");
    }

    double somme = 0;
    for (int i = 0; i < tabDeNotes.Length; i++)
    {
        if (tabDeNotes[i] < 0 || tabDeNotes[i] > 20)
        {
            throw new ArgumentOutOfRangeException("Les notes doivent être entre 0 et 20.");
        }
        somme += tabDeNotes[i];
    }
    double average = somme / tabDeNotes.Length;
    return average;
}

//-------------------------



try
{
    CalculMoyenne(tabDeNotes);

}

catch (InvalidArrayException e)
{
    Console.WriteLine(e);
}
catch (ArgumentOutOfRangeException e )
{
    Console.WriteLine(e);

}



Console.WriteLine("toto");