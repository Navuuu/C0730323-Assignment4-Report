using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.ReadTextFiles();
            Console.ReadLine();
        }
        public void Run() { this.ReadTextFiles();}
        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader("U:/Users/730323//Beowulf.txt"))
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
                Console.WriteLine($"File has {counter*5} Words.");
            }
        }
        public int FindNumberOfBlankSpaces(string line)
        {
            int countlettters = 0;
            int countSpaces = 0;
            foreach (char c in line)
            {
                if (char.IsLetter(c)) { countlettters++; }
                if (char.IsWhiteSpace(c)) { countSpaces++; }
            }
            return countSpaces;
        }

    }
}
