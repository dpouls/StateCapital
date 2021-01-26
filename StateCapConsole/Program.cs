using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCapConsole
{
    class Program
    {
        //variables to hold the values of what is in the text file
       static List<string> stateCapList = new List<string>();
       static Dictionary<string, string> stateCapDict = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            ReadStateCaps();

            Console.WriteLine("Welcome to the State Capital Lookup App");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Please enter a state and I will return the capital. (x to exit)");

            string userInput = Console.ReadLine().ToUpper();
            while (userInput != "X")
            { 
                string capital = "";
                if (SearchDict(userInput, ref capital))
                {
                    Console.WriteLine($"The capital of {userInput} is {capital}");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine($"Search for another state or type \"x\" to exit.");
                    userInput = Console.ReadLine().ToUpper();
                }
                else if (userInput == "RANDOM")
                {
                    GetRandomStateCap();
                    Console.WriteLine($"Search for another state or type \"x\" to exit.");
                    userInput = Console.ReadLine().ToUpper();
                }
                else
                {
                    Console.WriteLine("State not found. Search another state or type \"x\" to exit");
                    userInput = Console.ReadLine().ToUpper();
                }
                //if (SearchList(userInput, ref capital))
                //{
                //Console.WriteLine($"The capital of {userInput} is {capital}");
                //    Console.WriteLine("------------------------------------------");
                //    Console.WriteLine();
                //Console.WriteLine($"Search for another state or type \"x\" to exit.");

                //userInput = Console.ReadLine();
                //} else
                //{
                //    Console.WriteLine("State not found. Search anotehr state or type \"x\" to exit");
                //    userInput = Console.ReadLine();
                //}
                
            }
        }
        /// <summary>
        /// will grab a random state and capital from the state cap list. 
        /// </summary>
        private static void GetRandomStateCap()
        {
            Random rand = new Random();
            int randArrayIndex = rand.Next(0, stateCapList.Count);
            Console.WriteLine($"Random state and capital: {stateCapList[randArrayIndex]}");
        }
        /// <summary>
        /// Takes the user input and compares the state (key) to the dictionary that was created at the beginnning. If the key exists then it returns the value (capital)
        /// </summary>
        /// <param name="userInput"></param>
        /// <param name="capital"></param>
        /// <returns></returns>
        private static bool SearchDict(string userInput, ref string capital)
        {
            if (stateCapDict.TryGetValue(userInput, out capital))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Loops through a list that was created from the values from the text file. Compares the user input to the states and returns  a capital for the state that matches the user input
        /// </summary>
        /// <param name="userInput"></param>
        /// <param name="capital"></param>
        /// <returns></returns>
        private static bool SearchList(string userInput, ref string capital)
        {
            bool found = false;

            foreach (string state in stateCapList)
            {
                string[] tempstatecap = state.Split(',');
                if (userInput == tempstatecap[0])
                {
                    capital = tempstatecap[1];
                    return true;
                }

            }
            return false;
        }
        /// <summary>
        /// loads the file and copies its contents to a list and a dictionary. These values will be what we search through later. 
        /// </summary>
        private static void ReadStateCaps()
        {
            StreamReader inputfile;
            try
            {
                inputfile = File.OpenText(@"C:\Users\dalli\source\repos\StateCap\statecap.txt");
                string tempread = "";
                while (!inputfile.EndOfStream)
                {
                    tempread = inputfile.ReadLine();
                    stateCapList.Add(tempread);
                    string[] tempstatecap = tempread.Split(',');
                    stateCapDict.Add(tempstatecap[0].ToUpper(),tempstatecap[1].ToUpper());
                }
                inputfile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }
        }
    }
}
