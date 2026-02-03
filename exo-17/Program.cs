





List<int> validValues = new List<int>();

List<int> notValidValues = new List<int>();
int notValidTemp = 0;

do
{
    
    Console.WriteLine("Renseignez des températures, écrivez -999 pour sortir du programme");

    int userInput = int.Parse(Console.ReadLine());

    if (userInput == -999)
    {
        break;
    }

    if (userInput < -50 || userInput > 50)
    {
        notValidValues.Add(userInput);
        notValidTemp++;
    }

    else
    {
        validValues.Add(userInput);
    }

} while (true);








Console.WriteLine("nombre de valeur valides");
Console.WriteLine(validValues.Count());

Console.WriteLine();

Console.WriteLine("nombre de valeur non valides");
Console.WriteLine(notValidTemp);

/*
foreach(int values in validValues)
{
    int count = 0;
    
    Console.Write($" Valeurs valides N° {count} : {values},  ");
    count++;
}

Console.WriteLine();

foreach (int values in notValidValues)
{
    int count = 0;
    
    Console.Write($" Valeurs invalides N° {count}: { values},  ");
    count++;
}
*/


Console.WriteLine();
Console.WriteLine(" Témpérature mini et maxi");
validValues.Sort();

Console.WriteLine(validValues[0]);
Console.WriteLine(validValues[validValues.Count -1]);


