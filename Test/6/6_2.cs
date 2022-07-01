using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._6
{
    internal class _6_2
    {
        static void Main1(string[] args)
        {
            string path = "C:\\Users\\1302\\Desktop\\Gugudan.txt";

            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);

                for (int i = 2; i < 10; i++)
                {
                    sw.WriteLine(i + "단");
                    for (int j = 1; j < 10; j++)
                    {
                        sw.WriteLine($"{i} * {j} = {i * j}");
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
            }

            Console.WriteLine("구구단 파일 생성 완료");
        }
    }
}
