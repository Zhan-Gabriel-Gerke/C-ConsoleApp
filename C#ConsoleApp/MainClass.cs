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
        public static void Main(string[] args)
        {
            List<string> kuude_list = new List<string>();
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
                kuude_list.Add("April");
                kuude_list.Add("September");
                kuude_list.Add("Juuni");
                File.WriteAllLines(path, kuude_list);
                Console.WriteLine("OK");
                kuude_list.Clear();
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);
                }
                foreach (string kuu in kuude_list)
                {
                    Console.WriteLine(kuu);
                }
                kuude_list.Remove("Juuni");
                kuude_list[0] = "TEST kuuu";
                foreach (string kuu in kuude_list)
                {
                    Console.WriteLine(kuu);
                }
                Console.WriteLine("Sisesta kuu nimi, mida otsida:");
                string otsitav = Console.ReadLine();

                if (kuude_list.Contains(otsitav))
                    Console.WriteLine("Kuu " + otsitav + " on olemas.");
                else
                    Console.WriteLine("Sellist kuud pole.");
                File.WriteAllLines(path, kuude_list);

            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }
        }
    }
}