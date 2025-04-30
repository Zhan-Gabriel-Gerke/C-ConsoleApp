using System; //import modul
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates; // Added for File and Path classes
//"-Текст
//'-Символ

namespace C_ConsoleApp
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Opilane();
        }
        public static void Opilane()
        {
            List<Opilane> Opilased = new List<Opilane>();
            Opilane p1 = new Opilane();
            p1.Name = "Zhan";
            p1.Grades = new List<int>();
            p1.Grades.Add(1);
            p1.Grades.Add(2);
            p1.Grades.Add(3);

            Opilane p2 = new Opilane();
            p2.Name = "Gabrile";
            p2.Grades = new List<int>();
            p2.Grades.Add(2);
            p2.Grades.Add(3);
            p2.Grades.Add(4);

            Opilane p3 = new Opilane();
            p3.Name = "Gerke";
            p3.Grades = new List<int>();
            p3.Grades.Add(5);
            p3.Grades.Add(5);
            p3.Grades.Add(5);

            Opilased.Add(p1);
            Opilased.Add(p2);
            Opilased.Add(p3);
            double theBest = 0;
            string theBestName = ".";
            foreach (Opilane p in Opilased)
            {
                double kesk = 0;
                List<int> grades = p.Grades;
                for (int i = 0; i < grades.Count; i++)
                {
                    kesk = kesk + grades[i];
                }
                kesk = Math.Round(kesk / grades.Count);
                if (kesk > theBest)
                {
                    theBest = kesk;
                    theBestName = p.Name;
                }
                Console.WriteLine($"Avg Grade {kesk} Name {p.Name}");
            }
            Console.WriteLine($"The best student {theBestName}, Avg grade {theBest}");

        }
    }   

}