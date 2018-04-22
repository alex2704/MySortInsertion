using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class DataIO
    {
        public static int[] ReadFromFile(string filename)
        {
            string line = File.ReadAllText (filename);
            string[] mas = line.Split(new Char[] { ' ', ',', '.', ':', '\t' });
            int[] num = new int[mas.Length]; 
            for(int i=0;i<mas.Length-1;i++)
            {
                num[i] = Convert.ToInt32(mas[i]);
            }
            return num;
        }
        public static void WriteToFile(string[] mas, string filename)
        {
            using (StreamWriter sw = File.CreateText(filename))
            {
                for (int i = 0; i < mas.Length - 1; i++)
                {
                    sw.Write("{0} ",mas[i]);
                }
            }
        }
        public static string ReadFileToStr(string path)
        {
            return File.ReadAllText(path);
        }

        public static string[] ReadFileToStrArr(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}
