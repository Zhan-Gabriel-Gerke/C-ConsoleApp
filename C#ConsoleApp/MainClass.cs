using System; //import modul
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Added for File and Path classes
//"-Текст
//'-Символ

namespace C_ConsoleApp
{
    internal class MainClass
    {
        public static void First()
        {
            List<string> nimed = new List<string>();
            nimed.Add("Kati");
            nimed.Add("Mati");
            nimed.Add("Juku");

            if (nimed.Contains("Mati"))
                Console.WriteLine("Mati olemas");

            Console.WriteLine("Nimesid kokku: " + nimed.Count);

            nimed.Insert(1, "Sass");

            Console.WriteLine("Mati indeks: " + nimed.IndexOf("Mati"));
            Console.WriteLine("Mari indeks: " + nimed.IndexOf("Mari"));

            foreach (string nimi in nimed)
                Console.WriteLine(nimi);
        }
        public static void Second()
        {
            Tuple<float, char> route = new Tuple<float, char>(2.5f, 'N');
            Console.WriteLine($"Vahemaa: {route.Item1}, Suund: {route.Item2}");
        }
        public static void Thrid()
        {
            {
                List<Person> people = new List<Person>();
                people.Add(new Person() { Name = "Kadi" });
                people.Add(new Person() { Name = "Mirje" });

                foreach (Person p in people)
                    Console.WriteLine(p.Name);
            }
        }
        public static void Forth()
        {
            {
                LinkedList<int> loetelu = new LinkedList<int>();
                loetelu.AddLast(5);
                loetelu.AddLast(3);
                loetelu.AddFirst(0);

                foreach (int arv in loetelu)
                    Console.WriteLine(arv);

                loetelu.RemoveFirst();
                loetelu.RemoveLast();
                loetelu.AddLast(555);
                loetelu.Remove(555);
            }
        }
        public static void Fifth()
        {
            Dictionary<int, string> riigid = new Dictionary<int, string>();
            riigid.Add(1, "Hiina");
            riigid.Add(2, "Eesti");
            riigid.Add(3, "Itaalia");

            foreach (var paar in riigid)
                Console.WriteLine($"{paar.Key} - {paar.Value}");
            string pealinn = riigid[2];
            riigid[2] = "Eestimaa";
            riigid.Remove(3);
        }
        static void Main(string[] args)
        {
            First();
        }
    }
}