using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adam_Asmaca
{
    class sehirliste
    {
        public object Rastgelesehir()
        {
            ArrayList sehir = new ArrayList();
            sehir.Add("İSTANBUL");
            sehir.Add("KOCAELİ");
            sehir.Add("ANTALYA");
            sehir.Add("EDİRNE");
            sehir.Add("TEKİRDAĞ");
            sehir.Add("ANKARA");
            sehir.Add("ERZURUM");
            sehir.Add("ADANA");
            sehir.Add("DİYARBAKIR");
            sehir.Add("ZONGULDAK");
            sehir.Add("NİĞDE");
            sehir.Add("MERSİN");
            sehir.Add("GİRESUN");
            sehir.Add("HATAY");
            sehir.Add("YALOVA");
            sehir.Add("BİNGÖL");
            sehir.Add("BURSA");
            sehir.Add("AFYONKARAHİSAR");
            sehir.Add("DÜZCE");
            sehir.Add("SAKARYA");
            sehir.Add("AMASYA");
            sehir.Add("TRABZON");
            sehir.Add("ARTVİN");
            sehir.Add("BİTLİS");
            sehir.Add("GAZİANTEP");
            sehir.Add("KAHRAMANMARAŞ");
            sehir.Add("UŞAK");
            sehir.Add("DENİZLİ");
            sehir.Add("BİLECİK");
            sehir.Add("HAKKARİ");
            

            Random rastgele = new Random();
            int sayi = rastgele.Next(0, 29);


            object rastgelesehir = sehir[sayi];
            return rastgelesehir;


        }
        
    }
}
