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
            p.Letters();
            Console.ReadLine();
        }
        public void Run() { this.ReadTextFiles(); }
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


                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
                Console.WriteLine($"File has {counter * 5} Words.");
            }
        }
        public void Wordfinder()
        {
            int f = 0;
            foreach (var line in File.ReadAllLines("U:/Users/730323//Beowulf.txt"))
            {
                if (line.Contains("sea") && line.Contains("fare"))
                {
                    f++;
                }

            }
            Console.WriteLine(f);
        }
        public void Wordskipper()
        {
            int f = 0;
            foreach (var line in File.ReadAllLines("U:/Users/730323//Beowulf.txt"))
            {
                f++;
                if (line.Contains("fare") && (!line.Contains("war")))
                {
                    Console.WriteLine(f);
                }

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

        public void Letters()

        {



            StreamReader file = new StreamReader("U:/Users/730323//Beowulf.txt");

            string script = file.ReadToEnd();



            //find number of letters

            int numberOfLetters = 0;

            foreach (char letter in script)

            {

                numberOfLetters++;

            }

            var text = script.Trim();

            int wordCount = 0, index = 0;



            //find number of words

            while (index < text.Length)

            {

                // check if current char is part of a word

                while (index < text.Length && !char.IsWhiteSpace(text[index]))

                    index++;



                wordCount++;



                // skip whitespace until next word

                while (index < text.Length && char.IsWhiteSpace(text[index]))

                    index++;

            }



            float val2 = (float)numberOfLetters;

            float val1 = (float)wordCount;



            //find average

            float avrg = val2 / val1;

            Console.WriteLine(avrg);

        }

    }
    }

