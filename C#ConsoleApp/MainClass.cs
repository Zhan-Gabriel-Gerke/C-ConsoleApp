using System; //import modul
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.ComponentModel.Design; // Added for File and Path classes
//"-Текст
//'-Символ

namespace C_ConsoleApp
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //Klass1();
            //Parilus2();
            //Abstraktsioon3();
            //encapsulation4();
            //interface5();
            //NaideKasutuses();
            //BaasklassEx();
            //Alamklass3();
            //Alarmklass4();
            //Harjutus2();
            //Harjutus3();
            //Harjutus4();
            Harjutus5();
        }
        //public static void MoneyExchange()
        public static void Klass1()
        {
            Inimene inimene = new Inimene();
            inimene.Nimi = "Zhan";
            inimene.Tervita();
        }
        public static void Parilus2()
        {
            Tootaja Role = new Tootaja();
            Role.Nimi = "Zhan";
            Role.Ametikoht = "GEL";
            Role.Tootan();
        }
        public static void Abstraktsioon3()
        {
            //Koer loom = new Koer();
            Kass loom = new Kass();
            loom.Nimi = "Bruno";
            loom.TeeHaal();
        }
        public static void encapsulation4()
        {
            Pank Conto = new Pank();
            Conto.Saldo = 100;
            Console.WriteLine(Conto.Saldo);
            Console.WriteLine(Conto.Saldo);
        }
        public static void interface5()
        {
            Cat cat = new Cat();
            cat.TeeHääl();
        }
        /*public static void NaideKasutuses()
        {
            TootajaNaiteks Example1 = new TootajaNaiteks();
            Example1.Tunnitasu = 7;
            Example1.Nimi = "Matias";
            Example1.Vanus = 30;
            Example1.Tunnid = 100;
            double palk = Example1.ArvutaPalk();
            Console.WriteLine(Example1);
        }*/
        public static void BaasklassEx()
        {
            Baasklass Example1 = new Baasklass();
            Example1.Nimi = "Test";
            Example1.Sunniaasta = 2000;
            Example1.Kirjelda();
        }
        public static void Alamklass3()
        {
            Opetaja Example1 = new Opetaja();
            Example1.Nimi = "Test";
            Example1.Sunniaasta = 2000;
            Example1.TunnidNädalas = 50;
            Example1.Tunnitasu = 6;
            Example1.Kirjelda();
        }
        public static void Alarmklass4()
        {
            Opilane Example1 = new Opilane();
            Example1.Nimi = "Test";
            Example1.Sunniaasta = 2000;
            Example1.Kool = "TTHK";
            Example1.Klass = 13;
            Example1.Kirjelda();
        }
        public static void Harjutus2()
        {
            Direktor direktor = new Direktor
            {
                Nimi = "Ants Antson",
                Sunniaasta = 1970,
                Tunnitasu = 30,
                TunnidNädalas = 20,
                Lisatasu = 500
            };
            direktor.Kirjelda();
        }
        public static void Harjutus3()
        {
            Teacher teacher = new Teacher();
            teacher.Name = "Test";
            teacher.grade = 6;
            teacher.Hinda(teacher.grade);

        }
        public static void Harjutus4()
        {
            UliIpilane tudeng = new UliIpilane
            {
                Nimi = "Kaisa Kask",
                Sunniaasta = 2002,
                Kool = "TÜ",
                Klass = 1,
                Eriala = "Informaatika"
            };
            tudeng.Kirjelda();
        }
        public static void Harjutus5()
        {
            Opilane Example1 = new Opilane();
            Example1.Nimi = "Test";
            Example1.Sunniaasta = 2020;
            Example1.Kool = "TTHK";
            Example1.Klass = 13;
            Example1.Kirjelda();
            if (Example1.AdultOrNot())
                Console.WriteLine("Õpilane on täisealine.");
            else
                Console.WriteLine("Õpilane on alaealine.");

        }
    }
    /*overide - Можно изменить метод или свойство которое унаследовано
     * если метод или свойство было помечено virtual
     * 
     * инскапсуляция - скрытие данных и использование безопастных методов
     * для безопастного доступа
     */
}