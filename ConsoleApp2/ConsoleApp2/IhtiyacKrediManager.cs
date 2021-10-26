using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class IhtiyacKrediManager : IKrediManager//Interface si implement et
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("ihtiyaç Kredsisi hesaplama yapıldı");
        }
    }
}
