using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)  //Tek bir kredi
        {
            //Başvuran bilgilendirme değerlendirme
            krediManager.Hesapla();
            foreach (var logger in loggerService)
            {
                logger.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)  //Birden fazla kredi
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
