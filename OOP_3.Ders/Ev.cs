using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3.Ders
{
    //----Static----
    // *stack alanında adres gösterir
    // *bir class içindeki propertylere aynı değerleriyle tüm proje tarafından ortak olarak kullanılacaksa o classın static olması tercih edilir
    // *static classların içindeki değerler projenin her yerinde aynıdır
    public class Ev
    {
        private int kapiNumarasi;

        public static int OdaSayisi { get; set; } = 5;

        public int KapiNumarasi
        {
            get
            {
                return kapiNumarasi;
            }
            set
            {
                if (value>100)
                {
                    Console.WriteLine("Kapı Numarası 100'den büyük olamaz !!");
                }
                else
                {
                    this.kapiNumarasi = value;
                }
            }

        }
        public string Adres { get; set; } 

        //-----Constructor Method----
        // *class ismi ile aynı olmalı*
        // *geriye değer döndürmez (void dahil)*
        // *singleton mimarisi hariç public olmalı*
        // *classın dışarıya açılan kapısıdır*
        // *overload edilebilir*

        public Ev(int KapiNumarasi, int OdaSayisi, string Adres)
        {
            this.kapiNumarasi = KapiNumarasi;
            //this.OdaSayisi = OdaSayisi;
            this.Adres = Adres;
        }

         //*aynı fonksiyon farklı parametrelerle tanımlanıyorsa --overloading

        public Ev()
        {

        }

        public Ev(string Adres)
        {
            this.Adres = Adres;
        }

    }
}
