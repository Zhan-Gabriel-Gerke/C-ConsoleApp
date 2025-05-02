using System; //import modul
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal; // Added for File and Path classes
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
            encapsulation4();
        }
        //public static void MoneyExchange()
        public static void Klass1 ()
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
    }
}