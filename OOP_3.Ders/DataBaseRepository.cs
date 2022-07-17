using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3.Ders
{
    public class DataBaseRepository
    {
        // ----Singleton Mimarisi-----
        // *bir class her yerde ortak kullanılacak ancak stack alanına yığılma önlenmiş olur.
        // *belleği idareli kullanmamızı sağlar
        // *bir kere instance yapılması ve o instance ın projenin her yerinde kullanılabilmesini singleton mimarisi sağlar.
        
        public void ConnectDataBase()
        {
            Console.WriteLine("Bağlantı Başarılı");
        }

        static DataBaseRepository dataBase;
        // *her seferinde dışarıdan instance edilmemesi için ve GetInstance methoduna claasın ismiyle ulaşmak zorunda olduğumuz için static yaparız
        // *heap alanı
        public static DataBaseRepository GetInstance()
        {
            if (dataBase == null)
            {
                dataBase = new DataBaseRepository();
            }
            return dataBase;
        }
        // *dışarıdan instance edilememesi için private yaparız
        // *propertylere default değeri vermiş olduk.
        private DataBaseRepository()
        {

        }
    }
}
