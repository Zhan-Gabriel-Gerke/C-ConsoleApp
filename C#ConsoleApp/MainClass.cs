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
    }
}