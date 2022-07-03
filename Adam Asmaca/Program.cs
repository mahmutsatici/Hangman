using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adam_Asmaca
{
    class Program
    { 
        static void Main(string[] args)
        {
            
            Console.WriteLine("    ADAM ASMACA OYUNUNA");
            Console.WriteLine("        HOŞGELDİNİZ");
            Console.WriteLine("");
            Console.WriteLine("       _________ ");
            Console.WriteLine("      |    |     ");
            Console.WriteLine("      |    O     ");
            Console.WriteLine("      |   /|"+@"\");
            Console.WriteLine("      |  / | "+@"\");
            Console.WriteLine("      |    |     ");
            Console.WriteLine("      |    |     ");
            Console.WriteLine("      |   / "+@"\");
            Console.WriteLine("      |  /   " + @"\");
            Console.WriteLine("");
            Console.WriteLine("    Devam Etmek İçin");
            Console.WriteLine("         ENTER");
            Console.WriteLine("     Tuşuna Basınız");
            Console.ReadLine();
            Console.Clear();

            sehirliste o1 = new sehirliste();
            object rs = o1.Rastgelesehir();
            string sehir1 = (string)rs;
            
            string control = "";
            ArrayList sehirharfleri = new ArrayList();
            for (int i = 0; i < sehir1.Length; i++)
            {
                string harf2 = sehir1.Substring(i, 1);
                sehirharfleri.Add(harf2);
            }      // sehrin harflerini listeye ekledim
            ArrayList sehirharfleri1 = new ArrayList();
            sehirharfleri1.AddRange(sehirharfleri);

            string tahminedilenharfler = "";
            string bulunmayankelime = "";
            string bulunmayankelime2 = "*";
            int adam = 0;
            while (bulunmayankelime.Length != sehir1.Length)
            {
                bulunmayankelime = bulunmayankelime + "_";

            }
            do
            {
                Console.Clear();
                if (bulunmayankelime==bulunmayankelime2)
                {
                    adam++;
                }
                Console.WriteLine("**********************");
                if (adam == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("       _________ ");
                    Console.WriteLine("      |    |     ");
                    Console.WriteLine("      |       ");
                    Console.WriteLine("      |   ");
                    Console.WriteLine("      |  ");
                    Console.WriteLine("      |    ");
                    Console.WriteLine("      |   ");
                    Console.WriteLine("      |   ");
                    Console.WriteLine("      |  ");
                    Console.WriteLine("");
                }
                else if (adam == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("       _________ ");
                    Console.WriteLine("      |    |     ");
                    Console.WriteLine("      |    O  ");
                    Console.WriteLine("      |     ");
                    Console.WriteLine("      |    ");
                    Console.WriteLine("      |     ");
                    Console.WriteLine("      |    ");
                    Console.WriteLine("      |    ");
                    Console.WriteLine("      |   ");
                    Console.WriteLine("");
                }
                else if (adam == 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("       _________ ");
                    Console.WriteLine("      |    |     ");
                    Console.WriteLine("      |    O  ");
                    Console.WriteLine("      |    |");
                    Console.WriteLine("      |    |");
                    Console.WriteLine("      |    | ");
                    Console.WriteLine("      |    |");
                    Console.WriteLine("      |   ");
                    Console.WriteLine("      |  ");
                    Console.WriteLine("");
                }
                else if (adam == 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("       _________ ");
                    Console.WriteLine("      |    |     ");
                    Console.WriteLine("      |    O  ");
                    Console.WriteLine("      |   /|");
                    Console.WriteLine("      |  / |");
                    Console.WriteLine("      |    | ");
                    Console.WriteLine("      |    |");
                    Console.WriteLine("      |   ");
                    Console.WriteLine("      |  ");
                    Console.WriteLine("");
                }
                else if (adam == 5)
                {
                    Console.WriteLine("");
                    Console.WriteLine("       _________ ");
                    Console.WriteLine("      |    |     ");
                    Console.WriteLine("      |    O  ");
                    Console.WriteLine("      |   /|" + @"\");
                    Console.WriteLine("      |  / | " + @"\");
                    Console.WriteLine("      |    | ");
                    Console.WriteLine("      |    |");
                    Console.WriteLine("      |   ");
                    Console.WriteLine("      |  ");
                    Console.WriteLine("");
                }
                else if (adam == 6)
                {
                    Console.WriteLine("");
                    Console.WriteLine("       _________ ");
                    Console.WriteLine("      |    |     ");
                    Console.WriteLine("      |    O  ");
                    Console.WriteLine("      |   /|" + @"\");
                    Console.WriteLine("      |  / | " + @"\");
                    Console.WriteLine("      |    | ");
                    Console.WriteLine("      |    |");
                    Console.WriteLine("      |   /");
                    Console.WriteLine("      |  /");
                    Console.WriteLine("");
                }
                else if (adam == 7)
                {
                    Console.WriteLine("");
                    Console.WriteLine("       _________ ");
                    Console.WriteLine("      |    |     ");
                    Console.WriteLine("      |    O  ");
                    Console.WriteLine("      |   /|" + @"\");
                    Console.WriteLine("      |  / | " + @"\");
                    Console.WriteLine("      |    | ");
                    Console.WriteLine("      |    |");
                    Console.WriteLine("      |   / " + @"\");
                    Console.WriteLine("      |  /   " + @"\");
                    Console.WriteLine("");
                }
                else if (adam==0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("       _________        ");
                    Console.WriteLine("      |                 ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("      |            ");
                    Console.WriteLine("      |              ");
                    Console.WriteLine("      |            ");
                    Console.WriteLine("      |              ");
                    Console.WriteLine("      |            ");
                    Console.WriteLine("      |              ");
                    Console.WriteLine("");
                }


                Console.WriteLine("Tahmin Edilen Harfler: "+tahminedilenharfler);
                Console.WriteLine("**********************");
                Console.WriteLine("");
                Console.WriteLine("ŞEHİR: {0}", bulunmayankelime);            //kelimeyi istedim
                Console.WriteLine("BİR HARF GİRİNİZ");
                Console.WriteLine("KELİMEYİ TAHMİN EDECEKSENİZ BAŞINA YILDIZ KOYUN");
                string harf = Console.ReadLine();
                tahminedilenharfler = tahminedilenharfler + harf + ",";
                
                if (harf.Substring(0, 1) == "*")
                {
                    if ( (harf.Substring(1,(harf.Length)-1)).ToUpper() == sehir1)
                    {
                        control = "1";
                    }
                    else
                    {
                        control = "0";
                        adam = 6 ;

                    }
                }
                else
                {
                    if (harf.Length == 1)
                    {

                        bulunmayankelime2 = bulunmayankelime;
                        while (sehirharfleri.Contains(harf.ToUpper()))
                        {
                            int harfinlistesirasi = sehirharfleri.IndexOf(harf.ToUpper());
                            sehirharfleri[harfinlistesirasi] = "*";
                            
                            bulunmayankelime = "";
                            for (int j = 0; j < sehir1.Length; j++)
                            {
                                
                                if ((string)sehirharfleri[j]=="*")
                                {
                                    bulunmayankelime = bulunmayankelime + sehirharfleri1[j];

                                }
                                else
                                {
                                    bulunmayankelime = bulunmayankelime + "_";
                                    
                                }
                                
                            }
                            
                        }
                    }
                    else
                    {
                        Console.WriteLine("!!lütfen 1 adet harf giriniz!!");
                    }
                }
                int z = 0;
                string kontrol = "";
                while (z!=sehir1.Length)
                {
                    
                    if ((string)sehirharfleri[z] == "*")
                    {
                        kontrol = kontrol + "*";

                    }
                    z++;
                    if (kontrol.Length==sehir1.Length)
                    {
                        control = "1";
                    }
                    

                    
                }

                
            } while (control != "1" & control != "0" & adam!=6);
            Console.Clear();
            if (control=="1")
            {
                
                Console.WriteLine("***********************");
                Console.WriteLine("       " + sehir1);
                Console.WriteLine(" TEBRİKLER KAZANDINIZ");
                Console.WriteLine("***********************");
            }
            else
            {
                
                Console.WriteLine("");
                Console.WriteLine("       _________ ");
                Console.WriteLine("      |    |     ");
                Console.WriteLine("      |    O     ");
                Console.WriteLine("      |   /|" + @"\");
                Console.WriteLine("      |  / | " + @"\");
                Console.WriteLine("      |    |     ");
                Console.WriteLine("      |    |     ");
                Console.WriteLine("      |   / " + @"\");
                Console.WriteLine("      |  /   " + @"\");                              
                Console.WriteLine("");
                Console.WriteLine("KAYBETTİNİZ  :( ");
                Console.WriteLine("CEVAP = {0}",sehir1);
            }
            Console.ReadLine();

        }
        
    }
}
