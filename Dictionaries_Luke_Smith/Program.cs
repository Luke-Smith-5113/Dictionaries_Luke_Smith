using Microsoft.VisualBasic;
using System.Collections;

namespace Dictionaries_Luke_Smith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declares a new dictionary object names topGames that takes an int as a key and a string as a value
            Dictionary<int, string> topGames = new Dictionary<int, string>()
            {
                //initializes some entries in the dictionary to use later
                //I ran out of video games I could think of partway through
                { 1 , "Minecraft" },
                { 2 , "TotK" },
                { 3 , "Rimworld" },
                { 4 , "BotW" },
                { 5 , "Satisfactory" },
                { 6 , "Ryuutama" },
                { 7 , "MotW" },
                { 8 , "Subnautica" },
                { 9 , "Stardew" },
                { 10 , "Big Brain academy" }
            };
            //prints the key and value of every game in topGames, then checks whether that key is 1 and prints another message if it is
            foreach (var topGame in topGames) { Console.WriteLine($"Key: {topGame.Key}, Value: {topGame.Value}");
                if (topGame.Key == 1) { Console.WriteLine($"My favorite game is: {topGames[1]}"); } }
            //creates a string called result
            string result;
            //checks if there's a value at key 11, prints the value if it exists
            if (topGames.TryGetValue(11, out result)) { Console.WriteLine(result); }
            //writes that there's no game in the elevelth position if key 11 is empty
            else { Console.WriteLine("There is no game in the eleventh position."); }
            //checks if topGames contains a value at key 5 and removes it if it does
            if (topGames.ContainsKey(5)) { topGames.Remove(5);
                //adds a value and key for the key of 5
                topGames.Add(5, "Hollow Knight"); }
            //adds a value and key for the key of 5
            else { topGames.Add(5, "Hollow Knight"); }
            //writes the fifth entry of topGames to the console
            Console.WriteLine(topGames[5]);
            //creates a hashtable named myHash with a value of topGames after topGames has been converted into a hashtable
            Hashtable myHash = new Hashtable(topGames);
            //creates a string called favGame with the value of the entry with a key of 1 in myHash
            string favGame = myHash[1].ToString();
            //writes the string favGame to the console
            Console.WriteLine(favGame);
            //creates a new hashtable called capitals
            Hashtable capitals = new Hashtable()
            {
                //initializes a list of capitals
                {"Alabama", "Montgomery" },
                {"Alaska", "Juneau" },
                {"Arizona", "Pheonix" },
                {"California", "Sacramento" },
                {"Colorado", "Denver" }
            };
            //prints the key and value for every capital in capitals
            foreach(DictionaryEntry capital in capitals) { Console.WriteLine($"Key: {capital.Key}, Value: {capital.Value}"); }
            //clears the capitals hashtable
            capitals.Clear();
        }
    }
}