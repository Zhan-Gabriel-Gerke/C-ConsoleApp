using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ConsoleApp
{
    public abstract class Isik
    {
        // Инкапсуляция — приватное поле, публичное свойство
        private int sunniaasta;

        public string Nimi { get; set; } // Имя

        public int Sunniaasta
        {
            get { return sunniaasta; }
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year)
                    sunniaasta = value;
            }
        }

        // Вычисляемое свойство (только getter)
        public int Vanus => DateTime.Now.Year - sunniaasta;

        // Абстрактный метод — должен быть реализован в подклассах
        public abstract void Kirjelda();
    }
    public class Baasklass : Isik
    {
        public override void Kirjelda()
        {
            Console.WriteLine($"Description{Nimi}, {Sunniaasta}");
        }
    }
    public class Opetaja : Isik, ITooline
    {
        public double Tunnitasu { get; set; }
        public int TunnidNädalas { get; set; }

        public double ArvutaPalk()
        {
            return Tunnitasu * TunnidNädalas * 4; // Месячная зарплата (4 недели)
        }

        public override void Kirjelda()
        {
            Console.WriteLine($"Õpetaja {Nimi}, vanus {Vanus}, teenib kuus {ArvutaPalk():F2}€");//F2 - Два знака после запятой
        }
    }
    public class Opilane : Isik
    {
        public string Kool { get; set; }  // Школа
        public int Klass { get; set; }  // Класс

        public override void Kirjelda()
        {
            Console.WriteLine($"{Nimi} — {Vanus}-Year Old, Study at {Kool} in {Klass} Grade.");
        }
    }

}

