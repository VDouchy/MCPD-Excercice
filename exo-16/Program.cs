


string userInput = " ";

List<string> mots = new List<string>();



do
{


    Console.WriteLine("Saississez un mot: -(écrivez stop pour arrêter le programme");

    userInput = (Console.ReadLine());

    if (userInput.ToLower() == "stop")
        break;





    mots.Add(userInput);

} while (true);


foreach (string mot in mots)
{
    Console.WriteLine(mot);
}











