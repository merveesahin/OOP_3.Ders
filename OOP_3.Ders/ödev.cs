using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3.Ders
{
    public class ödev
    {
      
        static ödev tek = new ödev();
       
        public string getKullaniciAdi()
        {
            return "Merve";
        }
        public string getSifre()
        {
            return "123";
        }
        public static ödev nesneAl()
        {
            return tek;
        }
        private ödev()
        {

        }
    }
}
