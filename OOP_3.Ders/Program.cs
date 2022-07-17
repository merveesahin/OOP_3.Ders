using System;

namespace OOP_3.Ders
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ev ev = new Ev(5, 4, "İstanbul");

            //Console.WriteLine("Kapı Numarası {0}", ev.KapiNumarasi);
            //Console.WriteLine("Oda Sayısı {0}", ev.OdaSayisi);
            //Console.WriteLine("Adres {0}", ev.Adres);

            //Ev ev1 = new Ev();
            //Ev ev2 = new Ev("Ankara");

            //Console.WriteLine(Ev.Adres); // *staticler stack alanında

            Ev ev = new Ev();
            ev.Adres = "Sakarya";
            ev.KapiNumarasi = 10;

            Console.WriteLine(Ev.OdaSayisi); // *stack alanında
            Console.WriteLine(ev.Adres);
            Console.WriteLine(ev.KapiNumarasi);

            DataBaseRepository.GetInstance().ConnectDataBase();
        }
    }
}
