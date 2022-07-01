using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._5
{
    internal class _5_10
    {
        static void Main1(string[] args)
        {
            string[] arrNames = new string[5];

            arrNames[0] = "dog";
            arrNames[1] = "cow";
            arrNames[2] = "rabbit";
            arrNames[3] = "goat";
            arrNames[4] = "sheep";

            Console.WriteLine("배열");

            Array.Sort(arrNames);

            foreach (string item in arrNames)
                Console.Write(item + " ");
            Console.WriteLine();

            List<string> listName = new List<string>();
            listName.Add("dog");
            listName.Add("cow");
            listName.Add("rabbit");
            listName.Add("goat");
            listName.Add("sheep");


            listName.Sort();

            Console.WriteLine("리스트");

            foreach (string item in listName)
                Console.Write(item + " ");
            Console.WriteLine();

        }
    }
}
