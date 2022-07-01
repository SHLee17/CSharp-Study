using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch08
{
    internal class _3_FileIO
    {

        static void Main1(string[] args)
        {
            string path1 = "C:\\Users\\1302\\Desktop\\Sample.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(path1, FileMode.Open, FileAccess.Read);

                sr = new StreamReader(fs);

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("파일이 존재 하지 않습니다.");
            }
            finally
            {
                sr.Close();
                fs.Close();
            }
            // 스트링 생성
            

           

            string path2 = "C:\\Users\\1302\\Desktop\\Sample2.txt";

            FileStream outFs = null;
            StreamWriter sw = null;

            try
            {
                outFs = new FileStream(path2, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(outFs);

                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1; j < 10; j++)
                    {
                        sw.Write($"{i} x {j} = {i * j}\n");
                    }
                    sw.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {

                sw.Close();
                outFs.Close();
            }

            string f1 = "C:\\Users\\1302\\Desktop\\Sample.txt";
            string f3 = "C:\\Users\\1302\\Desktop\\Sample3.txt";


            try
            {
                using StreamReader reader = new StreamReader(new FileStream(f1, FileMode.Open));
                using StreamWriter writer = new StreamWriter(new FileStream(f3, FileMode.Create));

                string txt;

                while ((txt = reader.ReadLine())!= null)
                    writer.WriteLine(txt);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("프로그램 종료...");

          
        }



    }
}
