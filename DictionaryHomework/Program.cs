using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> animalList = new Dictionary<string, int>();
            animalList.Add("dog", 7);
            animalList.Add("cat", 20);
            animalList.Add("bird", 4);
            animalList.Add("fish", 2);
            animalList.Add("lamb", 15);

           if (animalList.ContainsKey("dog"))
            {
                int value = animalList["dog"];
                Console.WriteLine("Dog has " +value+ " legs");
            }
        } 
    }
}
