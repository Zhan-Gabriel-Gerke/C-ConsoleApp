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
            
        }
        public static void HeightAndSex()
        {
            Console.Write("Enter your height ");
            float Height = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter you sex ");
            string Sex = Console.ReadLine();
        }
        public static void Height()
        {
            Console.Write("Enter your height ");
            float Height = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (Height < 20)
            {
                Console.WriteLine("You are joking");
                Console.WriteLine("Hahah very funny");
            }
            else if (Height < 100)
            {
                Console.WriteLine("Very low");
            }
            else if (Height < 140)
            {
                Console.WriteLine("Write line");
            }
            else if (Height < 170)
            {
                Console.WriteLine("It's ok");
            }
            else
            {
                Console.WriteLine("High");
            }
            
        }
        public static void TempOfRoom()
        {
            Console.Write("How many degees celsius usually do you have in winter ");
            float TempC = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Is there any posibilities that the temperature can be below 18 degees celsius (At appartment)");
            Console.Write("Please enter Yes or No ");
            string YesOrNo = Console.ReadLine();
            if (YesOrNo == "Yes" || YesOrNo == "yes")
            {
                Console.WriteLine("The god it with you");
            }
        }
        public static void PRictangle()
        {
            Console.Write("Do you want to reconstract floot of the room? Please enter Yes Or No ");
            string YesOrNo = Console.ReadLine();
            if (YesOrNo == "Yes" || YesOrNo == "yes")
            {
                Console.Write("Please enter A side of the floor ");
                float a_var = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Please enter B side of the floor ");
                float b_var = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                float s_var = a_var * b_var;
                Console.WriteLine("S = " + s_var + "of the floor ");
                Console.Write("Please enter the price for the floor ");
                float price_for_sq_meter = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double start_price = (s_var * price_for_sq_meter) * 0.3;
                Console.WriteLine("Price of the start it's 30% = " + start_price);
            }
            else
            {
                Console.WriteLine("Ok, Bye");
            }

        }
        /*
        public static Isik[] Isikud(int k, string[] nimed, string[] aadressid)
        {
            Isik[] isikud = new Isik[k];

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(i);
                //isikud[i] = new Isik();
                Console.Write("Isikukood: ");
                isikud[i] = new Isik
                {
                    Nimi = nimed[i],
                    Vanus = 50,
                    Isikukood = Console.ReadLine(),
                    Aadress = aadressid[i]
                };
            }
            return isikud;
        }
        public static string Jukudef(string tekst, int vanus)
        {
            if (tekst.ToLower() == "juku")
            {
                Console.WriteLine("Lahme kinno!");
                try
                {
                    if (vanus <= 0 || vanus > 100) // || - or, && - and
                    {
                        return ("Viga");
                    }
                    else if (vanus > 0 && vanus <= 6)
                    {
                        return ("Tasuta");
                    }
                    else if (vanus <= 15)
                    {
                        return ("Lastepilet");
                    }
                    else if (vanus <= 65)
                    {
                        return ("TaisPilet");
                    }
                    else if (vanus <= 100)
                    {
                        return ("Sooduspilet!");
                    }
                }
                catch (Exception e)
                {
                    return ("Viga");
                }
            }
            else
            {
                return ("Olen hoivatud!");
            }
        */
    }
}