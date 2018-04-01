using System;

namespace Aufgabe_1_2
{
    class Program
    {
     
        static string[] subjects = { "Harry", "Hermine", "Ron", "Hagrid", "Snape", "Dumbledore"};
        static string[] verbs = { "braut", "liebt", "studiert", "hasst", "zaubert", "zerstört"};
        static string[] objects = { "Zaubertränke", "den Grimm", "Lupin", "Hogwards", "die Karte des Rumtreibers", "Dementoren"};

        static void Main(string[] args)
        {
            string[] poem = new string[5];
            for (int i = 0; i < poem.Length; i++)
            {
                poem[i] = GetVerse(poem, i);
            }
            for (int i = 0; i < poem.Length; i++)
            {
                Console.WriteLine(poem[i]);
            }
        }

        public static string GetVerse(string[] poem, int line)
        {
            Random rdm = new Random();
            string sub = subjects[rdm.Next(subjects.Length)];
            string ver = verbs[rdm.Next(verbs.Length)];
            string obj = objects[rdm.Next(objects.Length)];

            if (line==0){
                return sub + " " + ver + " " + obj;
            }else{
                for (int i = 0; i < line; i++){
                    if (poem[i].Contains(sub)){
                        sub = subjects[rdm.Next(subjects.Length)];
                        i = -1;
                    }
                }
                for (int i = 0; i < line; i++){
                    if (poem[i].Contains(ver)){
                        ver = verbs[rdm.Next(verbs.Length)];
                        i = -1;
                    }
                }
                for (int i = 0; i < line; i++){
                    if (poem[i].Contains(obj)){
                        obj = objects[rdm.Next(objects.Length)];
                        i = -1;
                    }
                }

                return sub + " " + ver + " " + obj;

            }
        }
    }
}
