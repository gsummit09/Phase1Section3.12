using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section3._12
{
    internal class Program
    {
        public static void doApp()
        {
            string dir =Directory.GetCurrentDirectory();
            Console.WriteLine(dir);
            string fileName = dir + "data.txt";
            if(File.Exists(fileName) ) 
            {
                Console.WriteLine(fileName + " exists");
            }
            else
            {
                Console.WriteLine(fileName+" does not exist");
            }
            using(StreamWriter sw = new StreamWriter(fileName)) 
            {
                sw.WriteLine(" This is line one");
                sw.WriteLine(" This is line Two");
                sw.WriteLine(" This is line Three");
                sw.WriteLine(" This is line four");

            }
            Console.WriteLine(fileName + " created");
            string[] lines = File.ReadAllLines(fileName);
            foreach(string s in lines )
            {
                Console.WriteLine(s);
            }
            string text = File.ReadAllText(fileName);
            Console.WriteLine(text);
            File.Delete(fileName);
            Console.WriteLine(fileName +" was deleted");
        }
        static void Main(string[] args)
        {
            doApp();
        }
    }
}
