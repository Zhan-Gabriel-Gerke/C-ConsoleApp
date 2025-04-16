using System; //import modul
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//"-Текст
//'-Символ
namespace C_ConsoleApp
{
    internal class MainClass
    {

        public static void Main(string[] args)
        {
            //II. osa Kordused, Massivid, Listid, Klassid
            List<string> sonad = FunktsioonideClass_2osa.Sonad();

            foreach (var item in sonad)
            {
                Console.WriteLine(item);
            }
            Isik isik1 = new Isik("Juku", 65, "12345678901", "Tallinn");
            isik1.PrindiInfo();
            Isik isik2 = new Isik();
            isik2.Nimi = "Mari";
            isik2.Aadress = "Tartu";
            isik2.Isikukood = "98765432101";
            isik2.Sugu = Sugu.Naine;
            isik2.PrindiInfo();

            int i;
            string[] nimed = new string[10] { "Juku", "Mari", "Kati", "Peeter", "Mati", "Liina", "Katrin", "Andres", "Marko", "Kristi" };
            string[] aadressid = new string[10] { "Tallinn", "Tartu", "Pärnu", "Narva", "Kohtla-Järve", "Viljandi", "Rakvere", "Paide", "Jõhvi", "Kuressaare" };
            Console.WriteLine("-----for++Massiv-------");
            Isik[] isikud = FunktsioonideClass_2osa.Isikud(nimed.Length, nimed, aadressid);
            for (i = 0; i < nimed.Length; i++)
            {
                isikud[i].PrindiInfo();
            }

            Console.WriteLine("-----for--List-------");
            List<Isik> isikud2 = new List<Isik>();
            for (int j = i - 1; j > -1; j--)
            {
                Console.WriteLine(j);
                Isik isik = new Isik
                {
                    Nimi = nimed[j],
                    Vanus = 50,
                    Isikukood = "111111111111",
                    Aadress = aadressid[j]
                };
                isikud2.Add(isik);
            }
            foreach (Isik isik in isikud2)
            {
                isik.PrindiInfo();
            }



            Console.WriteLine("-----while-------");
            while (i >= 0)
            {
                Console.WriteLine(i);
                i--;
            }
            Console.WriteLine("-----do-------");
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Backspace");
                key = Console.ReadKey();
            }
            while (key.Key != ConsoleKey.Backspace);

            /*
            Console.BackgroundColor = ConsoleColor.Green;//Цвет заднего фона текста
            Console.ForegroundColor = ConsoleColor.Blue;//Цвет текста
            Console.OutputEncoding = Encoding.UTF8;//Кодировка
            Console.WriteLine("Hello world");
            Одностроковый комент
            //Многострочный комент
            //Многострочный комент
            
            //Line - Enter
            int a = 0;
            string tekst = "Python";
            //char taht = 'A';
            //double arv = 1.23456789;
            float arv1 = 2;
            
            Console.WriteLine("Tere!\n" + tekst);
            Console.WriteLine("Tere!\n {0}",tekst);
            Console.Write("Mis on sunu nimi? ");//print
            tekst = Console.ReadLine();//Это как input
            Console.WriteLine("{0}\n Kui vana sa oled?", tekst);
            int vanus = int.Parse(Console.ReadLine());
            string answer = FunktsioonideClass.Jukudef(tekst, vanus);
            Console.WriteLine("Arv 2: ");
            int arv2 = int.Parse(Console.ReadLine());// int input
            //Console.WriteLine("Arvude {0} ja {1} korrutis vordub {2}", arv1, arv2, arv1*arv2);
            arv1 = FunktsioonideClass.Kalkulaator(a, arv2);//Вызов функции
            Console.WriteLine(arv1);

            Console.WriteLine(a);
            switch (a)
            {
                case 1: tekst = "E"; break;
                case 2: tekst = "T"; break;
                case 3: tekst = "K"; break;
                case 4: tekst = "N"; break;
                case 5: tekst = "R"; break;
                case 6: tekst = "L"; break;
                case 7: tekst = "P"; break;

                default:
                    tekst = "Tundmatu";
                    break;
            }
            */
        }
    }
}