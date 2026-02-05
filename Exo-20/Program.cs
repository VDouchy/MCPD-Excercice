



SortedSet<string> listParticipant = new SortedSet<string>()
{
    "Billy Banjo", "Zinedine Zywoo", " Mimim Mathy", "Patrick Teamspeak", " Mimim Mathy", "Bretzel Washington", "Zinedine Zywoo"
};



foreach (string p in listParticipant)
{
    Console.WriteLine(p);
}
Console.WriteLine();
foreach (string p in listParticipant)
{
    if (p == "Patrick Teamspeak" )
        Console.WriteLine($"le participant {p} est inscrit");
}


Console.WriteLine();
Console.WriteLine();
//-------------------CAS-2------------------------------------------
Queue<string> file = new Queue<string>();

file.Enqueue("Billy");
file.Enqueue("Patrick");
file.Enqueue("Zinedine");
file.Enqueue("Mimi");
file.Enqueue("Bretzel");





while(file.Count > 0)
{

    Console.WriteLine($"La client pris en charge est: {file.Dequeue()}");
    Console.WriteLine($"il reste : {file.Count}");
    Console.ReadLine();
        
}
    



Console.WriteLine("pause");

Console.WriteLine();
Console.WriteLine();



//---------------------------CAS-3-------------



Dictionary<string,int>elevesEtNotes = new Dictionary<string,int>();

elevesEtNotes["Billy"] = 12;
elevesEtNotes["Patrick"] = 02;
elevesEtNotes["Zinedine"] = 18;
elevesEtNotes["Mimi"] = 15;
elevesEtNotes["Bretzel"] = 03;



elevesEtNotes["Zinedine"] = 18;

Console.WriteLine(elevesEtNotes["Bretzel"]);



foreach(var e in elevesEtNotes)
    Console.WriteLine($"Nom = {e.Key}, Note = {e.Value}");