using System; //import modul
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Added for File and Path classes
using System.Globalization;//Нужно для получения float числа
//"-Текст
//'-Символ

namespace C_ConsoleApp
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //First();
            //Second();
            Third();
        }
        //public static int question(int Money, string Product, int Total)
        public static void First()
        {
            ArvuTreatment.GeenereeriRuudud();
        }
        public static void Second()
        {
            double[] doubleArray = ArvuTreatment.Text_figures();
            (double, double, double) tupledouble = ArvuTreatment.AnaluusiArve(doubleArray);
            Console.WriteLine(tupledouble);
        }
        public static void Third()
        {
            List<Inimene> inimesed = new List<Inimene>();
            for (int x = 0; x < 5; x++)
            {
                Console.Write("Enter Name ");
                string Name = Console.ReadLine();
                Console.Write("Enter age of the Person ");
                int vanus = int.Parse(Console.ReadLine());
                inimesed.Add(new Inimene {Nimi = Name, Vanus = vanus });
            }
            //inimesed.Add(new Inimene { Nimi = "Anna", Vanus = 30});
            (int summa_age, double avg_age, Inimene min, Inimene max) = Statistika(inimesed);
            Console.WriteLine($"Summa_age {summa_age}, Average age {avg_age}, Min age {min.Vanus}, Max age {max.Vanus}");
        }
        public static (int, double, Inimene, Inimene) Statistika(List<Inimene> inimesed)
        {
            int summa_age = 0;
            double avg_age = 0;
            Inimene min = inimesed[0];
            Inimene max = inimesed[0];
            foreach (Inimene inimene in inimesed)
            {
                int age = inimene.Vanus;
                summa_age = summa_age + age;
                avg_age = avg_age + age;
                if (inimene.Vanus < min.Vanus)
                {
                    min = inimene;
                }
                if (inimene.Vanus > max.Vanus)
                {
                    max = inimene;
                }
            }
            avg_age = avg_age / inimesed.Count;
            return (summa_age, avg_age, min, max);
        }
    }
}