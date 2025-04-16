using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ConsoleApp
{
    class Isik
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; } = 18;
        public string Isikukood { get; set; }
        public string Aadress { get; set; }
        // Пустой конструктор
        public Isik() { }
        // Конструктор с параметрами
        public Isik(string nimi, int vanus, string isikukood, string aadress)
        {
            Nimi = nimi;
            Vanus = vanus;
            Isikukood = isikukood;
            Aadress = aadress;
        }
        // Метод для вывода информации
        public void PrindInfo()
        {
            Console.WriteLine($"Имя: {Nimi}, Возраст: {Vanus}, ИНН: {Isikukood}, Адрес: {Aadress}");
        }
    }
}
