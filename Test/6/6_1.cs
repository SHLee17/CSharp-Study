using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._6
{
    internal class _6_1
    {
        static void Main1(string[] args)
        {
            Dictionary<string, string> colorDic = new Dictionary<string, string>();

            colorDic.Add("red", "빨강");
            colorDic.Add("green", "초록색");
            colorDic.Add("blue", "파란색");


            try
            {
                colorDic.Add("red", "빨강");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine("yellow : {0}", colorDic["yellow"]);
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            foreach (KeyValuePair<string,string> item in colorDic)
                Console.WriteLine("colorTable[{0}] : {1}" , item.Key,item.Value);
        }
    }
}
