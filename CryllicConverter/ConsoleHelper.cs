using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CryllicConverter
{
    public class ConsoleHelper
    {
        public DictionaryModel DM;

        //get input
        public string GetInput()
        {
            Console.WriteLine("Please input an alphanumeric string.");
            string input = Console.ReadLine();
            if (AlphanumericCheck(input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid input entered!");
                return GetInput();
            }
        }

        /// <summary>
        /// Checks if a string is Alphanumeric
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool AlphanumericCheck(string n)
        {
            Regex r = new Regex("^[a-zA-Z0-9]*$");
            return r.IsMatch(n);
        }

        //print output
        public void PrintOutput(string result)
        {
            DM = new DictionaryModel();
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(result);
            Console.WriteLine("Decoding Table: ");
            foreach(var kvp in DM.cryllicMap)
            {
                Console.WriteLine("Key = {0}, Value = {1} ", kvp.Key, kvp.Value);
            }
            Console.ReadKey();
        }
    }
}
