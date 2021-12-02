using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Frozen
{
    class Program
    {
        class Frozen
        {
            string name;
            string gift;

            public Frozen(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
            }
            public string Name
            {
                get { return name; }
            }
            public string Gift
            {
                get { return gift; }
            }
        }
        static void Main(string[] args)
        {
            List<string> frozenListFromFile = getFrozenFromfile().ToList();
            List<Frozen> listOfFrozen = new List<Frozen>();

            foreach (string frozenRecord in frozenListFromFile)
            {
                string[] tempArray = frozenRecord.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Frozen newFrozen = new Frozen(tempArray[0], tempArray[1]);

                listOfFrozen.Add(newFrozen);
            }
           
            foreach (Frozen frozen in listOfFrozen)
            {
                Console.WriteLine($"Name: {frozen.Name} - Gift: {frozen.Gift}");
            }
        }          
        public static string[] getFrozenFromfile()
        {
            string filePath = @"C:\Users\opilane\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
        public static void ShowDataFromArray(string[] someArray)
        {
            foreach (string line in someArray)
            {
                Console.WriteLine(line);
            }
        }
    }
}
