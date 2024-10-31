using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Bankamatik_Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bakiye = 25000.00;
            Console.WriteLine("Kartlı 1 / kartsız 2 ");
        Hatalı:

            int kartİslemi = Convert.ToInt32(Console.ReadLine());

            if (kartİslemi == 1)
                
            {
                Console.WriteLine("işlem kartlı");
            sifrehatası:

                Console.WriteLine("Şifre");
                string? sifre = (Console.ReadLine());
                if (sifre == "ab18")
                {
                    Console.WriteLine("Giriş Başarılı");
                }
                else
                {
                    Console.WriteLine("Giriş başarısız");
                    goto sifrehatası;
                }

                Thread.Sleep(1000);
                Console.Clear();



            //MAİN MENU
            secim1:
            secim2:
                hatalıHesapNo:
                Console.WriteLine("Para çekmek       1");
                Console.WriteLine("Para yatırmak     2");
                Console.WriteLine("Para transferleri 3");
                Console.WriteLine("Eğitim ödemeleri  4");
                Console.WriteLine("Ödemeler          5");
                Console.WriteLine("Bilgi güncelleme  6");
                int anaMenuSecimi = Convert.ToInt32(Console.ReadLine());

                Thread.Sleep(1000);
                Console.Clear();


                if (anaMenuSecimi == 1)
                {
                    Console.WriteLine("Çekilmek istenen tutar: ");

                   
                    double tutar = Convert.ToDouble(Console.ReadLine());

                    if (tutar > bakiye)
                    {
                        Console.WriteLine("Yetersiz bakiye.");

                    }
                    else
                    {
                        Console.WriteLine("Para çekim talebiniz onaylanmıştır.");
                        bakiye = bakiye - tutar;
                        Console.WriteLine("Kalan bakiye" + bakiye);
                    }
                    Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                    int secim1 = Convert.ToInt32(Console.ReadLine());
                    if (secim1 == 9)
                    {
                        Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                        goto secim1;

                    }

                    else if (secim1 == 0)
                    {
                        Console.WriteLine("Çıkış yapılıyor..");
                        Environment.Exit(0);
                    }


                }
                Thread.Sleep(1000);
                Console.Clear();
               
               
                if (anaMenuSecimi == 2)
                {
                    Console.WriteLine("Kredi Kartı 1\nKendi Hesabınız için 2");
                    Console.WriteLine("Ana menü için 9\nÇıkış için 0");

                    double krediKartHesap = Convert.ToDouble(Console.ReadLine());

                    if (krediKartHesap ==1)
                    {
                        Console.WriteLine("Kredi kardı için en az 12 haneli kart numarasını girin ");
                        string? kartNo = Console.ReadLine();
                        if (kartNo.Length == 12)
                        {
                            Console.WriteLine("Yatırılacak Miktar: ");
                            double miktar = Convert.ToDouble(Console.ReadLine());
                             bakiye = miktar + bakiye;
                            Console.WriteLine("Güncel Bakiye: "  + bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Hesap no.");
                            goto hatalıHesapNo;
                        }
                    }                 
                   else if (krediKartHesap == 2)
                    {
                        Console.WriteLine("Yatırılacak para miktarı: ");
                        double yatırma = Convert.ToDouble(Console.ReadLine());
                        bakiye  = yatırma + bakiye;
                        Console.WriteLine("Güncel bakiyeniz: " + bakiye);

                    }
                    Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                    int secim2 = Convert.ToInt32(Console.ReadLine());
                    if (secim2 == 9)
                    {
                        Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                        goto secim2;

                    }

                    else if (secim2 == 0)
                    {
                        Console.WriteLine("Çıkış yapılıyor..");
                        Environment.Exit(0);
                    }



                }
                if (anaMenuSecimi==3)
                {
                    Console.WriteLine("Başka hesaba EFT 1\nBaşka hesaba havale 2");
                    int havaleEFT = Convert.ToInt32(Console.ReadLine());

                    if (havaleEFT == 1)
                    {
                        Console.WriteLine("EFT Numarası: ");
                        string eftNo = Console.ReadLine();
                        if (eftNo.StartsWith("TR") && eftNo.Length==12)
                        {   

                            
                            Console.WriteLine("Transfer miktar: ");
                            double eftTutar = Convert.ToDouble(Console.ReadLine());
                           if (eftTutar > bakiye)
                            {
                                Console.WriteLine("Yetersiz bakiye");
                                Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                                int secim10 = Convert.ToInt32(Console.ReadLine());
                                if (secim10 == 9)
                                {
                                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                                    goto secim2;

                                }

                                else if (secim10 == 0)
                                {
                                    Console.WriteLine("Çıkış yapılıyor..");
                                    Environment.Exit(0);
                                }
                            }
                            else
                            {
                                bakiye = bakiye - eftTutar;
                                Console.WriteLine("Güncel bakiyeniz: " + bakiye);

                                Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                                int secim10 = Convert.ToInt32(Console.ReadLine());
                                if (secim10 == 9)
                                {
                                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                                    goto secim2;

                                }

                                else if (secim10 == 0)
                                {
                                    Console.WriteLine("Çıkış yapılıyor..");
                                    Environment.Exit(0);
                                }
                            }
                            

                        }
                        else
                        {
                            Console.WriteLine("Hatalı Numara");



                            Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                            int secim10 = Convert.ToInt32(Console.ReadLine());
                            if (secim10 == 9)
                            {
                                Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                                goto secim2;

                            }

                            else if (secim10 == 0)
                            {
                                Console.WriteLine("Çıkış yapılıyor..");
                                Environment.Exit(0);
                            }
                        }
                        

                    }
                    //------------
                    else if (havaleEFT == 2)
                    {
                        Console.WriteLine("11 haneli hesap numarasını gitin: ");
                        string hesapNo = Console.ReadLine();
                        if (hesapNo.Length == 11)
                        {
                           
                            Console.WriteLine("Transfer miktarı");
                            double havale = Convert.ToDouble(Console.ReadLine());
                            if (bakiye > havale)
                            {
                                bakiye = bakiye - havale;
                                Console.WriteLine("Transfer sağlanmıştır. Güncel bakiye " + bakiye);                             
                                Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                                int secim10 = Convert.ToInt32(Console.ReadLine());
                                if (secim10 == 9)
                                {
                                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                                    goto secim2;

                                }

                                else if (secim10 == 0)
                                {
                                    Console.WriteLine("Çıkış yapılıyor..");
                                    Environment.Exit(0);
                                }
                            }
                            else if (bakiye < havale)
                            {
                                Console.WriteLine("Yetersiz bakiye: ");                            
                                Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                                int secim10 = Convert.ToInt32(Console.ReadLine());
                                if (secim10 == 9)
                                {
                                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                                    goto secim2;

                                }

                                else if (secim10 == 0)
                                {
                                    Console.WriteLine("Çıkış yapılıyor..");
                                    Environment.Exit(0);
                                }
                            }


                        }
                        else
                        {
                            Console.WriteLine("Hatalı hesap numarası");
                    
                            Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                            int secim10 = Convert.ToInt32(Console.ReadLine());
                            if (secim10 == 9)
                            {
                                Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                                goto secim2;

                            }

                            else if (secim10 == 0)
                            {
                                Console.WriteLine("Çıkış yapılıyor..");
                                Environment.Exit(0);
                            }
                        }
                            


                    }

                }
                if (anaMenuSecimi == 4)
                {
                    Console.WriteLine("Eğitim ödemeleri alanımız şu an pasiftir.");

                    Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                    int secim4 = Convert.ToInt32(Console.ReadLine());
                    if (secim4 == 9)
                    {
                        Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                        goto secim2;

                    }

                    else if (secim4 == 0)
                    {
                        Console.WriteLine("Çıkış yapılıyor..");
                        Environment.Exit(0);
                    }
                }
                Thread.Sleep(1000);
                Console.Clear();
                if (anaMenuSecimi==5)
                {
                    Console.WriteLine("Elektrik Faturası 1");
                    Console.WriteLine("Telefon Faturası  2");
                    Console.WriteLine("İnternet Faturası 3");
                    Console.WriteLine("Su Faturası       4");
                    Console.WriteLine("OGS Faturası      5");
                    int faturaSecim = Convert.ToInt32(Console.ReadLine());
                    if (faturaSecim == 1)
                    {
                        Console.WriteLine("Elektrik Fatura Tutarını giriniz: ");
                        double elektrik = Convert.ToDouble(Console.ReadLine());
                         if(bakiye > elektrik)
                        {
                            bakiye = bakiye - elektrik;
                            Console.WriteLine("Fatura ödenmiştir. Güncel bakiye: " + bakiye);
                        }
                         else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }
                        Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                        int secim5 = Convert.ToInt32(Console.ReadLine());
                        if (secim5 == 9)
                        {
                            Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                            goto secim2;

                        }

                        else if (secim5 == 0)
                        {
                            Console.WriteLine("Çıkış yapılıyor..");
                            Environment.Exit(0);
                        }

                    }
                    if (faturaSecim == 2)
                    {
                        Console.WriteLine("Telefon Fatura Tutarını giriniz: ");
                        double telefon = Convert.ToDouble(Console.ReadLine());
                        if (bakiye > telefon)
                        {
                            bakiye = bakiye - telefon;
                            Console.WriteLine("Fatura ödenmiştir. Güncel bakiye: " + bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }
                        Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                        int secim6 = Convert.ToInt32(Console.ReadLine());
                        if (secim6 == 9)
                        {
                            Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                            goto secim2;

                        }

                        else if (secim6 == 0)
                        {
                            Console.WriteLine("Çıkış yapılıyor..");
                            Environment.Exit(0);
                        }
                    }
                    if (faturaSecim == 3)
                    {
                        Console.WriteLine("İnternet Fatura Tutarını giriniz: ");
                        double internet = Convert.ToDouble(Console.ReadLine());
                        if (bakiye > internet)
                        {
                            bakiye = bakiye - internet;
                            Console.WriteLine("Fatura ödenmiştir. Güncel bakiye: " + bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }
                        Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                        int secim7 = Convert.ToInt32(Console.ReadLine());
                        if (secim7 == 9)
                        {
                            Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                            goto secim2;

                        }

                        else if (secim7 == 0)
                        {
                            Console.WriteLine("Çıkış yapılıyor..");
                            Environment.Exit(0);
                        }
                    }
                    if (faturaSecim == 4)
                    {
                        Console.WriteLine("Su Fatura Tutarını giriniz: ");
                        double su = Convert.ToDouble(Console.ReadLine());
                        if (bakiye > su)
                        {
                            bakiye = bakiye - su;
                            Console.WriteLine("Fatura ödenmiştir. Güncel bakiye: " + bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }
                        Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                        int secim8 = Convert.ToInt32(Console.ReadLine());
                        if (secim8 == 9)
                        {
                            Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                            goto secim2;

                        }

                        else if (secim8 == 0)
                        {
                            Console.WriteLine("Çıkış yapılıyor..");
                            Environment.Exit(0);
                        }
                    }
                    if (faturaSecim == 5)
                    {
                        Console.WriteLine("OGS Fatura Tutarını giriniz: ");
                        double ogs = Convert.ToDouble(Console.ReadLine());
                        if (bakiye > ogs)
                        {
                            bakiye = bakiye - ogs;
                            Console.WriteLine("Fatura ödenmiştir. Güncel bakiye: " + bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }
                        Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                        int secim8 = Convert.ToInt32(Console.ReadLine());
                        if (secim8 == 9)
                        {
                            Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                            goto secim2;

                        }

                        else if (secim8 == 0)
                        {
                            Console.WriteLine("Çıkış yapılıyor..");
                            Environment.Exit(0);
                        }
                    }
                    


                }
                if (anaMenuSecimi == 6)
                {
                    Console.WriteLine("Yeni Şifreniz: ");
                    string sifre2 = Console.ReadLine();
                    sifre = sifre2;
                    Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                    int secim9 = Convert.ToInt32(Console.ReadLine());
                    if (secim9 == 9)
                    {
                        Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                        goto secim2;

                    }

                    else if (secim9 == 0)
                    {
                        Console.WriteLine("Çıkış yapılıyor..");
                        Environment.Exit(0);
                    }
                }


            }
            //KARTSIZ
            else if (kartİslemi == 2)
            {
                Console.WriteLine("işlem kartsız");
            sifrehatası:

                Console.WriteLine("Şifre");
                string? sifre = (Console.ReadLine());
                if (sifre == "ab18")
                {
                    Console.WriteLine("Giriş Başarılı");
                }
                else
                {
                    Console.WriteLine("Giriş başarısız");
                    goto sifrehatası;
                }

                Thread.Sleep(1000);
                Console.Clear();

                // Main Menu 2
                secimkartsız:
                Console.WriteLine("CepBank Para çekmek 1");
                Console.WriteLine("Para yatırmak için  2");
                Console.WriteLine("Kredi kartı ödeme   3");
                Console.WriteLine("Eğitim ödemeleri    4");
                Console.WriteLine("Ödemeler            5");
                int anaMenuSecimi2 = Convert.ToInt32(Console.ReadLine());
                Thread.Sleep(1000);
                Console.Clear();

                if (anaMenuSecimi2 == 1)
                {
                    

                    Console.WriteLine("Tckn giriniz: ");
                    long tckn = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Telefon No: ");
                    long tel = Convert.ToInt64(Console.ReadLine());                 
                   
                    if (tckn == 10826551402 && tel == 05343504262)
                    {
                        bakiye = bakiye + 1000;
                        Console.WriteLine("Güncel bakiye: " + bakiye);
                        Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                        int secim8 = Convert.ToInt32(Console.ReadLine());
                        if (secim8 == 9)
                        {
                            Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                            goto secimkartsız;

                        }

                        else if (secim8 == 0)
                        {
                            Console.WriteLine("Çıkış yapılıyor..");
                            Environment.Exit(0);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Bilgiler hatalıdır.");
                        Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                        int secim8 = Convert.ToInt32(Console.ReadLine());
                        if (secim8 == 9)
                        {
                            Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                            goto secimkartsız;

                        }

                        else if (secim8 == 0)
                        {
                            Console.WriteLine("Çıkış yapılıyor..");
                            Environment.Exit(0);
                        }

                    }



                }
                Thread.Sleep(1000);
                Console.Clear();
                if (anaMenuSecimi2 == 2)
                {
                    Console.WriteLine("Nakit ödeme    1");
                    Console.WriteLine("Hesaptan ödeme 2");
                    int yatırmak = Convert.ToInt32(Console.ReadLine());
                    if (yatırmak == 1)
                    {
                        Console.WriteLine("Kredi kartı için en az 12 haneli numara");
                        string kkNo = Console.ReadLine();
                        if (kkNo.Length >12)
                        {
                            Console.WriteLine("Tc numaranız: ");
                            string tc = Convert.ToString(Console.ReadLine());
                            if (tc.Length==11)
                            {
                                Console.WriteLine("Nakit miktarı: ");
                                double miktar = Convert.ToDouble(Console.ReadLine());
                                bakiye = bakiye + miktar;
                                Console.WriteLine("İşlem tamamlanmıştır. Güncel Bakiyeniz: " + bakiye);


                                Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                                int secim8 = Convert.ToInt32(Console.ReadLine());
                                if (secim8 == 9)
                                {
                                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                                    goto secimkartsız;

                                }

                                else if (secim8 == 0)
                                {
                                    Console.WriteLine("Çıkış yapılıyor..");
                                    Environment.Exit(0);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Tc bilgisiniz yanlıştır");
                                Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                                int secim8 = Convert.ToInt32(Console.ReadLine());
                                if (secim8 == 9)
                                {
                                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                                    goto secimkartsız;

                                }

                                else if (secim8 == 0)
                                {
                                    Console.WriteLine("Çıkış yapılıyor..");
                                    Environment.Exit(0);
                                }
                            }

                            
                        }
                        else
                        {
                            Console.WriteLine("Kart bilgisi yanlıştır.");
                            Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                            int secim8 = Convert.ToInt32(Console.ReadLine());
                            if (secim8 == 9)
                            {
                                Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                                goto secimkartsız;

                            }

                            else if (secim8 == 0)
                            {
                                Console.WriteLine("Çıkış yapılıyor..");
                                Environment.Exit(0);
                            }

                        }
                    }
                    else if(yatırmak == 2)
                    {
                        Console.WriteLine("Kredi kartı için en az 12 haneli numara: ");
                        string kkNo = Console.ReadLine();
                        if (kkNo.Length>12)
                        {
                            Console.WriteLine("Yatırılımak istenilen tutar: ");
                            int tutar = Convert.ToInt32(Console.ReadLine());

                            bakiye = bakiye + tutar;
                            Console.WriteLine("Güncel bakiyeniz: " + bakiye);
                            Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                            int secim8 = Convert.ToInt32(Console.ReadLine());
                            if (secim8 == 9)
                            {
                                Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                                goto secimkartsız;

                            }

                            else if (secim8 == 0)
                            {
                                Console.WriteLine("Çıkış yapılıyor..");
                                Environment.Exit(0);
                            }

                        }
                        else
                        {
                            Console.WriteLine("Hatalı kart numarası.");
                            Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                            int secim8 = Convert.ToInt32(Console.ReadLine());
                            if (secim8 == 9)
                            {
                                Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                                goto secimkartsız;

                            }

                            else if (secim8 == 0)
                            {
                                Console.WriteLine("Çıkış yapılıyor..");
                                Environment.Exit(0);
                            }
                        }

                    }

                }
                Thread.Sleep(1000);
                Console.Clear();
                if (anaMenuSecimi2 == 3)
                {
                   
                    Console.WriteLine("Başka hesaba EFT     1");
                    Console.WriteLine("Başka hesaba Havale  2");
                    int haveft = Convert.ToInt32(Console.ReadLine());
                    if (haveft == 1)
                    {
                        Console.WriteLine("EFT numarası: ");
                        string eftNo = Console.ReadLine();
                        if (eftNo.StartsWith("TR")&&eftNo.Length==12)
                        {
                            Console.WriteLine("Yatırılacak miktar: ");
                            int miktar = Convert.ToInt32(Console.ReadLine());
                            bakiye = bakiye + miktar;
                            Console.WriteLine("İşlem başarılıdır. " + bakiye);
                            Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                            int secim8 = Convert.ToInt32(Console.ReadLine());
                            if (secim8 == 9)
                            {
                                Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                                goto secimkartsız;

                            }

                            else if (secim8 == 0)
                            {
                                Console.WriteLine("Çıkış yapılıyor..");
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı EFT numarası.");
                            Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                            int secim8 = Convert.ToInt32(Console.ReadLine());
                            if (secim8 == 9)
                            {
                                Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                                goto secimkartsız;

                            }

                            else if (secim8 == 0)
                            {
                                Console.WriteLine("Çıkış yapılıyor..");
                                Environment.Exit(0);
                            }

                        }
                    }
                    else if (haveft == 2)
                    {
                        Console.WriteLine("11 Haneli Hesap No: ");
                        string hesapNo = Console.ReadLine();
                        if (hesapNo.Length== 11)
                        {
                            Console.WriteLine("Yatırmak istediğiniz miktar: ");
                            int miktar = Convert.ToInt32(Console.ReadLine());
                            bakiye = bakiye + miktar;
                            Console.WriteLine("İşlem başarılıdır. Güncel bakiyeniz: "+ bakiye);
                            Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                            int secim8 = Convert.ToInt32(Console.ReadLine());
                            if (secim8 == 9)
                            {
                                Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                                goto secimkartsız;

                            }

                            else if (secim8 == 0)
                            {
                                Console.WriteLine("Çıkış yapılıyor..");
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı hesap numarası");
                            Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                            int secim8 = Convert.ToInt32(Console.ReadLine());
                            if (secim8 == 9)
                            {
                                Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                                goto secimkartsız;

                            }

                            else if (secim8 == 0)
                            {
                                Console.WriteLine("Çıkış yapılıyor..");
                                Environment.Exit(0);
                            }
                        }
                    }


                }
                Thread.Sleep(1000);
                Console.Clear();
                if (anaMenuSecimi2 == 4)
                {
                    Console.WriteLine("Eğitim Ödemeleri sayfası arızalı.");
                    Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                    int secim8 = Convert.ToInt32(Console.ReadLine());
                    if (secim8 == 9)
                    {
                        Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                        goto secimkartsız;

                    }

                    else if (secim8 == 0)
                    {
                        Console.WriteLine("Çıkış yapılıyor..");
                        Environment.Exit(0);
                    }
                }
                Thread.Sleep(1000);
                Console.Clear();
                if (anaMenuSecimi2 == 5)
                {
                    Console.WriteLine("Elektrik Faturası 1");
                    Console.WriteLine("Telefon Faturası  2");
                    Console.WriteLine("İnternet Faturası 3");
                    Console.WriteLine("Su Faturası       4");
                    Console.WriteLine("OGS Faturası      5");
                    int faturaSecim = Convert.ToInt32(Console.ReadLine());
                    if (faturaSecim == 1)
                    {
                        Console.WriteLine("Elektrik Fatura Tutarını giriniz: ");
                        double elektrik = Convert.ToDouble(Console.ReadLine());
                        if (bakiye > elektrik)
                        {
                            bakiye = bakiye - elektrik;
                            Console.WriteLine("Fatura ödenmiştir. Güncel bakiye: " + bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }
                        Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                        int secim5 = Convert.ToInt32(Console.ReadLine());
                        if (secim5 == 9)
                        {
                            Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                            goto secimkartsız;

                        }

                        else if (secim5 == 0)
                        {
                            Console.WriteLine("Çıkış yapılıyor..");
                            Environment.Exit(0);
                        }

                    }
                    if (faturaSecim == 2)
                    {
                        Console.WriteLine("Telefon Fatura Tutarını giriniz: ");
                        double telefon = Convert.ToDouble(Console.ReadLine());
                        if (bakiye > telefon)
                        {
                            bakiye = bakiye - telefon;
                            Console.WriteLine("Fatura ödenmiştir. Güncel bakiye: " + bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }
                        Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                        int secim6 = Convert.ToInt32(Console.ReadLine());
                        if (secim6 == 9)
                        {
                            Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                            goto secimkartsız;

                        }

                        else if (secim6 == 0)
                        {
                            Console.WriteLine("Çıkış yapılıyor..");
                            Environment.Exit(0);
                        }
                    }
                    if (faturaSecim == 3)
                    {
                        Console.WriteLine("İnternet Fatura Tutarını giriniz: ");
                        double internet = Convert.ToDouble(Console.ReadLine());
                        if (bakiye > internet)
                        {
                            bakiye = bakiye - internet;
                            Console.WriteLine("Fatura ödenmiştir. Güncel bakiye: " + bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }
                        Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                        int secim7 = Convert.ToInt32(Console.ReadLine());
                        if (secim7 == 9)
                        {
                            Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                            goto secimkartsız;

                        }

                        else if (secim7 == 0)
                        {
                            Console.WriteLine("Çıkış yapılıyor..");
                            Environment.Exit(0);
                        }
                    }
                    if (faturaSecim == 4)
                    {
                        Console.WriteLine("Su Fatura Tutarını giriniz: ");
                        double su = Convert.ToDouble(Console.ReadLine());
                        if (bakiye > su)
                        {
                            bakiye = bakiye - su;
                            Console.WriteLine("Fatura ödenmiştir. Güncel bakiye: " + bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }
                        Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                        int secim8 = Convert.ToInt32(Console.ReadLine());
                        if (secim8 == 9)
                        {
                            Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                            goto secimkartsız;

                        }

                        else if (secim8 == 0)
                        {
                            Console.WriteLine("Çıkış yapılıyor..");
                            Environment.Exit(0);
                        }
                    }
                    if (faturaSecim == 5)
                    {
                        Console.WriteLine("OGS Fatura Tutarını giriniz: ");
                        double ogs = Convert.ToDouble(Console.ReadLine());
                        if (bakiye > ogs)
                        {
                            bakiye = bakiye - ogs;
                            Console.WriteLine("Fatura ödenmiştir. Güncel bakiye: " + bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }
                        Console.WriteLine("Ana menü için 9\nÇıkış için 0");
                        int secim8 = Convert.ToInt32(Console.ReadLine());
                        if (secim8 == 9)
                        {
                            Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                            goto secimkartsız;

                        }

                        else if (secim8 == 0)
                        {
                            Console.WriteLine("Çıkış yapılıyor..");
                            Environment.Exit(0);
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("Hatalı");
                Console.WriteLine("Kartlı 1 / kartsız 2 ");
                goto Hatalı;
            }
           
         
            
            
          
               









        }
 }   }

