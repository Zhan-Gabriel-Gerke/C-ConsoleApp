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
            Parilus2();
        }
        //public static void MoneyExchange()
        public static void Klass1 ()
        {
            Inimene inimene = new Inimene();
            inimene.Nimi = "Zhan";
            inimene.
            inimene.Tervita();
        }
        public static void Parilus2()
        {
           Tootaja Role = new Tootaja();
            Role.Ametikoht = "GEL";
            Role.Tootan();
        }
    }
}