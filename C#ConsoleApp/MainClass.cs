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
            //Opilane();(
            //AnimalsSystem();
            MoneyExchange();
        }
        public static void MoneyExchange()
        {
            List<Valuuta> Current = new List<Valuuta>();
            Valuuta USD = new Valuuta();
            USD.Name = "Name";
            USD.Exchangerate = 1.14;
            Valuuta RUB = new Valuuta();
            RUB.Name = "Rubles";
            RUB.Exchangerate = 92.41;
            Current.Add(USD);
            Current.Add(RUB);
            var tempvar = Exchange();
            //tempvar.Item1 = Current
            //tempvar.Item2 = Exchangerate
        }
        public static (string, int) Exchange()
        {
            Console.Write("Enter name of the current USD, RUB ");
            string current = Console.ReadLine();
            Console.WriteLine("What do you want");
            Console.WriteLine($"From EUR to {current} Enter - 1");
            Console.WriteLine($"From {current} to EUR Enter - 2");
            int options = int.Parse(Console.ReadLine());
            return (current, options);
        }
        public static void AnimalsSystem()
        {
            List<Lemmikloom> Animals = new List<Lemmikloom>();
            Lemmikloom a1 = new Lemmikloom();
            a1.Name = "Bruno";
            a1.Type = "Dog";
            a1.Age = 3;

            Lemmikloom a2 = new Lemmikloom();
            a2.Name = "Karla";
            a2.Type = "Cat";
            a2.Age = 10;

            Lemmikloom a3 = new Lemmikloom();
            a3.Name = "Trickel";
            a3.Type = "Dog";
            a3.Age = 1;

            Lemmikloom a4 = new Lemmikloom();
            a4.Name = "Sharik";
            a4.Type = "Dog";
            a4.Age = 15;

            Lemmikloom a5 = new Lemmikloom();
            a5.Name = "Max";
            a5.Type = "Dog";
            a5.Age = 8;

            Animals.Add (a1);
            Animals.Add (a2);
            Animals.Add (a3);
            Animals.Add (a4);
            Animals.Add (a5);
            double theOldestAge = 0;
            string theOldest = ".";
            double kesk = 0;
            foreach (Lemmikloom a in Animals)
            {
                if (a.Type == "Cat")
                {
                    Console.WriteLine($"Name {a.Name}, {a.Type}, Age {a.Age}");
                }
                for (int i = 0; i < Animals.Count; i++)
                {
                    kesk = kesk + a.Age;
                }
                kesk = Math.Round(kesk / Animals.Count);
                if (a.Age > theOldestAge)
                {
                    theOldestAge = kesk;
                    theOldest = a.Name;
                }
            }
            Console.WriteLine($"The oldest animal it's {theOldest}, {theOldestAge} Year Old");
            Console.WriteLine($"Avg age {kesk}");
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