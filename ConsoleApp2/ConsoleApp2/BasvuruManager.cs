using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class BasvuruManager
    {
        

        public void BasvuruYap(IKrediManager krediManager)//istediğimiz krediyi göndere biliriz onun metodları çalışır
                {


            krediManager.Hesapla();//Başvuru kredi bağımsız hale getirild                
       //  public void KrediOnBilgilendirme(List<IKrediManager>krediler)//Herbir kredinin hesabı yapılacak

            {
                foreach(var kredi in krediler)
                {
                    kredi.Hesapla();
                }

            }
        }
    }
}
