using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankamatik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*****BANKAMATİK ODEVİ * ***
            #region Bankamatik
            /*   
                 
            Bir Bankamatik düşünülerek tasarlanacak bir program yazın. 
            // 250 tl parası olacak


            Kartlı işlem    1
            Kartsız işlem   2

            //Kartsız işlem menüsü arızalı!

            //***Kartlı işlem bölümü****

            Şifre istenecek=> Şifre:ab18
            ==> şifrenin 3 defa yanlış olması halinde sistemden atılacak,değilse Ana Menü

            //******Ana Menü***** 
            Para Çekmek için    1
            Para yatırmak için  2
            Para Transferleri   3
            Eğitim Ödemeleri    4
            Ödemeler            5
            Bilgi Güncelleme    6

            //********Seçim 1*******
            Bakiye yeterli ise para çekilecek,değilse yetersiz bakiye
            Ana menüye dönmek için   9
            Çıkmak için             0

            //*******Seçim 2********
            Kredi Kartına   1
            Kendi Hesabınıza yatırmak için  2
            Ana Menü        9
            Çıkmak için     0
            //------------------------------------

            //----1
            Kredi kardı için en az 12 haneli kart numarasını girsin
            bakiye yeterli ise hesaptan kredi kartına para yatırılaca
            Ana Menü        9
            Çıkmak için     0
            //----------------------------------

            //---2
            hesaba yatırılacak para değeri istenir veişlem gerçekleştirilir
            Ana Menü        9
            Çıkmak için     0

            //**********Seçim 3*******
            Başka Hesaba EFT    1
            Başka Hesaba Havale 2
            //---------------------------------

            //--1
            EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
            yatılacak para istenir ,hesap uygun ise işlem gerçekleşir değilse
            Ana Menü        9
            Çıkmak için     0
            //-----------------------------

            //---2
            hesap için 11 haneli hesap numarası işlemler doğru ise
            gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
            Ana Menü        9
            Çıkmak için     0

            //*********Seçim 4**********
            Eğitim Ödemeleri sayfası arızalı
            Ana Menü        9
            Çıkmak için     0

            //*********Seçim 5**********
            Elektrik Faturası       1
            Telefon Faturası        2
            İnternet faturası       3
            Su Faturası             4
            OGS Ödemeleri           5
            //-----------------------------------------

            //---1 => bütün faturala için aşağıdaki şart yeterli
            fatura tutarı istenir, hesap uygun ise yatırılır değilse
            Ana Menü        9
            Çıkmak için     0
            //-----------------------------------

            //*********Seçim 6********
            Şifre değiştirmek için 1
            Şifre değiştirme işlemi gerçekleştirilir
            Ana Menü        9
            Çıkmak için     0

             */
            #endregion
            Console.WriteLine("Lütfen Yapmak istediğiniz işlemi seçiniz: \n1-) Kartlı işlem \n2-) Kartsız işlem");
            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                int hak = 3;

                while (hak > 0)
                {
                    string sifre = "ab18";
                    Console.WriteLine("Şifreniz: ");
                    string password = Console.ReadLine();

                    if (sifre == password)
                    {
                        Console.WriteLine("Giriş Başarılı. Ana menüye yönlendiriliyorsunuz");
                        Console.WriteLine("******Ana Menü*****\n Para Çekmek için 1\n Para yatırmak için 2\n Para Transferleri için 3\n Eğitim Ödemeleri için 4\n Ödemeler için 5\n Bilgi Güncelleme için 6");
                        int secim2 = int.Parse(Console.ReadLine());

                        switch (secim2)
                        {
                            case 1:
                                Console.WriteLine("Ne kadar para çekmek istiyorsunuz?\nBakiyeniz: 250 TL");
                                int cekme = int.Parse(Console.ReadLine());

                                if (cekme <= 250)
                                {
                                    Console.WriteLine("Paranız hazırlanıyor, lütfen paranızı almayı unutmayın, iyi günler dileriz.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz bakiye.\nAna menü için 9 \nÇıkmak için 0");
                                    int secim3 = int.Parse(Console.ReadLine());
                                    if (secim3 == 9)
                                    {
                                        Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                        continue;
                                    }
                                    else if (secim3 == 0)
                                    {
                                        Console.WriteLine("İyi günler dileriz.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı seçim yaptınız");
                                        break;
                                    }
                                }
                                break;

                            case 2:

                                Console.WriteLine("Hangi hesaba para yatırmak istiyorsunuz?\nKredi Karı için 1\nKendi hesabınız için 2\nAna menü için 9 \nÇıkmak için 0");
                                int yatirma = int.Parse(Console.ReadLine());

                                if (yatirma == 1)
                                {
                                    Console.WriteLine("12 haneli Kredi kartı numarasınız giriniz");
                                    long kart_numarasi = 123456789876;
                                    kart_numarasi = long.Parse(Console.ReadLine());

                                    if (kart_numarasi == 123456789876)
                                    {
                                        Console.WriteLine("Ne kadar para yatırmak istiyorsunuz?");
                                        int bakiye = int.Parse(Console.ReadLine());
                                        if (bakiye <= 250)
                                        {
                                            Console.WriteLine("Para yatırılıyor");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz bakiye.\nAna menü için 9 \nÇıkmak için 0");
                                            int secim5 = int.Parse(Console.ReadLine());
                                            if (secim5 == 9)
                                            {
                                                Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                                continue;
                                            }
                                            else if (secim5 == 0)
                                            {
                                                Console.WriteLine("İyi günler dileriz.");
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Hatalı seçim yaptınız");
                                                break;
                                            }
                                        }
                                    }

                                    else
                                    {
                                        Console.WriteLine("Hatalı kart numarası girdiniz. \nAna menü için 9 \nÇıkmak için 0");
                                        int secim6 = int.Parse(Console.ReadLine());
                                        if (secim6 == 9)
                                        {
                                            Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                            continue;
                                        }
                                        else if (secim6 == 0)
                                        {
                                            Console.WriteLine("İyi günler dileriz.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hatalı seçim yaptınız");
                                            break;
                                        }
                                        continue;
                                    }

                                    break;
                                }
                                else if (yatirma == 2)
                                {
                                    Console.WriteLine("Yatırmak istediğiniz tutarı Para yatırma alanına yerleştiriniz. İyi günler dileriz");
                                    break;
                                }
                                else if (yatirma == 9)
                                {
                                    Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                    continue;
                                }
                                else if (yatirma == 0)
                                {
                                    Console.WriteLine("İyi günler dileriz.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı seçim yaptınız");
                                    break;
                                }
                                break;

                            case 3:

                                Console.WriteLine("Başka hesaba EFT için 1,\nBaşka hesaba Havale için 2, yi tuşlayınız.");
                                int secim4 = int.Parse(Console.ReadLine());
                                if (secim4 == 1)
                                {
                                    string EFT = "TR111111111111";
                                    Console.WriteLine("Lütfen EFT numarasını giriniz");
                                    EFT = Console.ReadLine();
                                    if (EFT == "TR111111111111")
                                    {
                                        Console.WriteLine("Lütfen yatırılacak para miktarını giriniz?");
                                        int bakiye = int.Parse(Console.ReadLine());
                                        if (bakiye <= 250)
                                        {
                                            Console.WriteLine("Para yatırılıyor. İyi günler dileriz.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz bakiye.\nAna menü için 9 \nÇıkmak için 0");
                                            int secim7 = int.Parse(Console.ReadLine());
                                            if (secim7 == 9)
                                            {
                                                Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                                continue;
                                            }
                                            else if (secim7 == 0)
                                            {
                                                Console.WriteLine("İyi günler dileriz.");
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Hatalı seçim yaptınız");
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı EFT numarası girdiniz.\nAna menü için 9 \nÇıkmak için 0 ");
                                        int secim8 = int.Parse(Console.ReadLine());
                                        if (secim8 == 9)
                                        {
                                            Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                            continue;
                                        }
                                        else if (secim8 == 0)
                                        {
                                            Console.WriteLine("İyi günler dileriz.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hatalı seçim yaptınız");
                                            break;
                                        }
                                    }
                                }
                                else if (secim4 == 2)
                                {
                                    Console.WriteLine("Lütfen Hesap numarası giriniz: ");
                                    long hesap_numarasi = 123456789876;
                                    hesap_numarasi = long.Parse(Console.ReadLine());
                                    if (hesap_numarasi == 123456789876)
                                    {
                                        Console.WriteLine("Lütfen yatırılacak para miktarını giriniz?");
                                        int bakiye = int.Parse(Console.ReadLine());
                                        if (bakiye <= 250)
                                        {
                                            Console.WriteLine("Para yatırılıyor. İyi günler dileriz.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz bakiye.\nAna menü için 9 \nÇıkmak için 0");
                                            int secim9 = int.Parse(Console.ReadLine());
                                            if (secim9 == 9)
                                            {
                                                Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                                continue;
                                            }
                                            else if (secim9 == 0)
                                            {
                                                Console.WriteLine("İyi günler dileriz.");
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Hatalı seçim yaptınız");
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı hesap numarası numarası girdiniz.\nAna menü için 9 \nÇıkmak için 0 ");
                                        int secim10 = int.Parse(Console.ReadLine());
                                        if (secim10 == 9)
                                        {
                                            Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                            continue;
                                        }
                                        else if (secim10 == 0)
                                        {
                                            Console.WriteLine("İyi günler dileriz.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hatalı seçim yaptınız");
                                            break;
                                        }
                                    }
                                }

                                break;

                            case 4:

                                Console.WriteLine("Eğitim ödemeleri bölümü arızalıdır, daha sonra tekrar deneyiniz.\nAna menü için 9 \nÇıkmak için 0  ");
                                int secim11 = int.Parse(Console.ReadLine());
                                if (secim11 == 9)
                                {
                                    Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                    continue;
                                }
                                else if (secim11 == 0)
                                {
                                    Console.WriteLine("İyi günler dileriz.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı seçim yaptınız");
                                    break;
                                }

                                break;

                            case 5:

                                Console.WriteLine("Hangi faturayı ödemek istersiniz?*\n1-) Elektrik\n2-) Telefon\n3-) İnternet\n4-) Su\n5-) OGS");
                                int secim12 = int.Parse(Console.ReadLine());

                                if (secim12 == 1)
                                {
                                    Console.WriteLine("Elektrik Fatura miktarınız giriniz:\n");
                                    int bakiye = int.Parse(Console.ReadLine());
                                    if (bakiye <= 250)
                                    {
                                        Console.WriteLine("Para yatırılıyor. İyi günler dileriz.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz bakiye.\nAna menü için 9 \nÇıkmak için 0");
                                        int secim13 = int.Parse(Console.ReadLine());
                                        if (secim13 == 9)
                                        {
                                            Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                            continue;
                                        }
                                        else if (secim13 == 0)
                                        {
                                            Console.WriteLine("İyi günler dileriz.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hatalı seçim yaptınız");
                                            break;
                                        }
                                    }

                                }
                                else if (secim12 == 2)
                                {
                                    Console.WriteLine("Telefon Fatura miktarınız giriniz:\n");
                                    int bakiye = int.Parse(Console.ReadLine());
                                    if (bakiye <= 250)
                                    {
                                        Console.WriteLine("Para yatırılıyor. İyi günler dileriz.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz bakiye.\nAna menü için 9 \nÇıkmak için 0");
                                        int secim13 = int.Parse(Console.ReadLine());
                                        if (secim13 == 9)
                                        {
                                            Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                            continue;
                                        }
                                        else if (secim13 == 0)
                                        {
                                            Console.WriteLine("İyi günler dileriz.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hatalı seçim yaptınız");
                                            break;
                                        }
                                    }

                                }
                                else if (secim12 == 3)
                                {
                                    Console.WriteLine("İnternet Fatura miktarınız giriniz:\n");
                                    int bakiye = int.Parse(Console.ReadLine());
                                    if (bakiye <= 250)
                                    {
                                        Console.WriteLine("Para yatırılıyor. İyi günler dileriz.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz bakiye.\nAna menü için 9 \nÇıkmak için 0");
                                        int secim13 = int.Parse(Console.ReadLine());
                                        if (secim13 == 9)
                                        {
                                            Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                            continue;
                                        }
                                        else if (secim13 == 0)
                                        {
                                            Console.WriteLine("İyi günler dileriz.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hatalı seçim yaptınız");
                                            break;
                                        }
                                    }

                                }
                                else if (secim12 == 4)
                                {
                                    Console.WriteLine("Su Fatura miktarınız giriniz:\n");
                                    int bakiye = int.Parse(Console.ReadLine());
                                    if (bakiye <= 250)
                                    {
                                        Console.WriteLine("Para yatırılıyor. İyi günler dileriz.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz bakiye.\nAna menü için 9 \nÇıkmak için 0");
                                        int secim13 = int.Parse(Console.ReadLine());
                                        if (secim13 == 9)
                                        {
                                            Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                            continue;
                                        }
                                        else if (secim13 == 0)
                                        {
                                            Console.WriteLine("İyi günler dileriz.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hatalı seçim yaptınız");
                                            break;
                                        }
                                    }

                                }
                                else if (secim12 == 5)
                                {
                                    Console.WriteLine("OGS Fatura miktarınız giriniz:\n");
                                    int bakiye = int.Parse(Console.ReadLine());
                                    if (bakiye <= 250)
                                    {
                                        Console.WriteLine("Para yatırılıyor. İyi günler dileriz.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz bakiye.\nAna menü için 9 \nÇıkmak için 0");
                                        int secim13 = int.Parse(Console.ReadLine());
                                        if (secim13 == 9)
                                        {
                                            Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                            continue;
                                        }
                                        else if (secim13 == 0)
                                        {
                                            Console.WriteLine("İyi günler dileriz.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hatalı seçim yaptınız");
                                            break;
                                        }
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Hatalı numara tuşadınız. \nAna menü için 9 \nÇıkmak için 0 ");
                                    int secim14 = int.Parse(Console.ReadLine());
                                    if (secim14 == 9)
                                    {
                                        Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                        continue;
                                    }
                                    else if (secim14 == 0)
                                    {
                                        Console.WriteLine("İyi günler dileriz.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı seçim yaptınız");
                                        break;
                                    }
                                }

                                break;

                            case 6:

                                Console.WriteLine("Şifrenizi değiştirmek istiyor musunuz?\nEvet için 1\nAna menü için 9 \nÇıkmak için 0 ");
                                int secim15 = int.Parse(Console.ReadLine());

                                if (secim15 == 1)
                                {
                                    Console.WriteLine("Lütfen yeni şifrenizi giriniz: ");
                                    string yeni_sifre = Console.ReadLine();
                                    Console.WriteLine("Lütfen yeni şifrenizi tekrar giriniz: ");
                                    string yeni_sifre_tekrar = Console.ReadLine();
                                    if (yeni_sifre == yeni_sifre_tekrar)
                                    {
                                        sifre = yeni_sifre;
                                        Console.WriteLine("Şifreniz değiştirildi. Yeni Şifreniz:" + yeni_sifre + " Ana menüye yönlendiriliyorsunuz");
                                        continue;
                                    }

                                    else
                                    {
                                        Console.WriteLine("Hatalı şiifre tuşladınız.\nEvet için 1\nAna menü için 9 \nÇıkmak için 0");
                                        int secim16 = int.Parse(Console.ReadLine());
                                        if (secim16 == 9)
                                        {
                                            Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                            continue;
                                        }
                                        else if (secim16 == 0)
                                        {
                                            Console.WriteLine("İyi günler dileriz.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hatalı seçim yaptınız");
                                            break;
                                        }
                                    }
                                }
                                else if (secim15 == 9)
                                {
                                    Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                    continue;
                                }
                                else if (secim15 == 0)
                                {
                                    Console.WriteLine("İyi günler dileriz.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı seçim yaptınız");
                                    break;
                                }

                                break;


                        }
                        break;


                    }
                    else
                    {
                        Console.WriteLine("Kullanıcı adı veya şifre hatalı lütfen Tekrar deneyiniz!");
                    }

                    hak--;
                    Console.WriteLine("\nKalan Hakkınız: " + hak);
                }





            }

            else if (secim == 2)
            {
                Console.WriteLine("Kartsız işlem menüsü arızalıdır!!!");
                Console.WriteLine("Ne yapmak istersiniz?: \nÇıkmış yapmak için 9 tuşuna,\nKartlı işlem yapmak için 1 tuşuna basınız");
                int secenek = int.Parse(Console.ReadLine());

                if (secenek == 9)
                {
                    Console.WriteLine("İyi günler dileriz. Kartınız iade ediliyor");
                }

                else if (secenek == 1)
                {
                    {
                        int hak = 3;

                        while (hak > 0)
                        {
                            string sifre = "ab18";
                            Console.WriteLine("Şifreniz: ");
                            string password = Console.ReadLine();

                            if (sifre == password)
                            {
                                Console.WriteLine("Giriş Başarılı. Ana menüye yönlendiriliyorsunuz");
                                Console.WriteLine("******Ana Menü*****\n Para Çekmek için 1\n Para yatırmak için 2\n Para Transferleri için 3\n Eğitim Ödemeleri için 4\n Ödemeler için 5\n Bilgi Güncelleme için 6");
                                int secim2 = int.Parse(Console.ReadLine());

                                switch (secim2)
                                {
                                    case 1:
                                        Console.WriteLine("Ne kadar para çekmek istiyorsunuz?\nBakiyeniz: 250 TL");
                                        int cekme = int.Parse(Console.ReadLine());

                                        if (cekme <= 250)
                                        {
                                            Console.WriteLine("Paranız hazırlanıyor, lütfen paranızı almayı unutmayın, iyi günler dileriz.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz bakiye.\nAna menü için 9 \nÇıkmak için 0");
                                            int secim3 = int.Parse(Console.ReadLine());
                                            if (secim3 == 9)
                                            {
                                                Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                                continue;
                                            }
                                            else if (secim3 == 0)
                                            {
                                                Console.WriteLine("İyi günler dileriz.");
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Hatalı seçim yaptınız");
                                                break;
                                            }
                                        }
                                        break;

                                    case 2:

                                        Console.WriteLine("Hangi hesaba para yatırmak istiyorsunuz?\nKredi Karı için 1\nKendi hesabınız için 2\nAna menü için 9 \nÇıkmak için 0");
                                        int yatirma = int.Parse(Console.ReadLine());

                                        if (yatirma == 1)
                                        {
                                            Console.WriteLine("12 haneli Kredi kartı numarasınız giriniz");
                                            long kart_numarasi = 123456789876;
                                            kart_numarasi = long.Parse(Console.ReadLine());

                                            if (kart_numarasi == 123456789876)
                                            {
                                                Console.WriteLine("Ne kadar para yatırmak istiyorsunuz?");
                                                int bakiye = int.Parse(Console.ReadLine());
                                                if (bakiye <= 250)
                                                {
                                                    Console.WriteLine("Para yatırılıyor");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Yetersiz bakiye.\nAna menü için 9 \nÇıkmak için 0");
                                                    int secim5 = int.Parse(Console.ReadLine());
                                                    if (secim5 == 9)
                                                    {
                                                        Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                                        continue;
                                                    }
                                                    else if (secim5 == 0)
                                                    {
                                                        Console.WriteLine("İyi günler dileriz.");
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Hatalı seçim yaptınız");
                                                        break;
                                                    }
                                                }
                                            }

                                            else
                                            {
                                                Console.WriteLine("Hatalı kart numarası girdiniz. \nAna menü için 9 \nÇıkmak için 0");
                                                int secim6 = int.Parse(Console.ReadLine());
                                                if (secim6 == 9)
                                                {
                                                    Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                                    continue;
                                                }
                                                else if (secim6 == 0)
                                                {
                                                    Console.WriteLine("İyi günler dileriz.");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Hatalı seçim yaptınız");
                                                    break;
                                                }
                                                continue;
                                            }

                                            break;
                                        }
                                        else if (yatirma == 2)
                                        {
                                            Console.WriteLine("Yatırmak istediğiniz tutarı Para yatırma alanına yerleştiriniz. İyi günler dileriz");
                                            break;
                                        }
                                        else if (yatirma == 9)
                                        {
                                            Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                            continue;
                                        }
                                        else if (yatirma == 0)
                                        {
                                            Console.WriteLine("İyi günler dileriz.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hatalı seçim yaptınız");
                                            break;
                                        }
                                        break;

                                    case 3:

                                        Console.WriteLine("Başka hesaba EFT için 1,\nBaşka hesaba Havale için 2, yi tuşlayınız.");
                                        int secim4 = int.Parse(Console.ReadLine());
                                        if (secim4 == 1)
                                        {
                                            string EFT = "TR111111111111";
                                            Console.WriteLine("Lütfen EFT numarasını giriniz");
                                            EFT = Console.ReadLine();
                                            if (EFT == "TR111111111111")
                                            {
                                                Console.WriteLine("Lütfen yatırılacak para miktarını giriniz?");
                                                int bakiye = int.Parse(Console.ReadLine());
                                                if (bakiye <= 250)
                                                {
                                                    Console.WriteLine("Para yatırılıyor. İyi günler dileriz.");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Yetersiz bakiye.\nAna menü için 9 \nÇıkmak için 0");
                                                    int secim7 = int.Parse(Console.ReadLine());
                                                    if (secim7 == 9)
                                                    {
                                                        Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                                        continue;
                                                    }
                                                    else if (secim7 == 0)
                                                    {
                                                        Console.WriteLine("İyi günler dileriz.");
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Hatalı seçim yaptınız");
                                                        break;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Hatalı EFT numarası girdiniz.\nAna menü için 9 \nÇıkmak için 0 ");
                                                int secim8 = int.Parse(Console.ReadLine());
                                                if (secim8 == 9)
                                                {
                                                    Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                                    continue;
                                                }
                                                else if (secim8 == 0)
                                                {
                                                    Console.WriteLine("İyi günler dileriz.");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Hatalı seçim yaptınız");
                                                    break;
                                                }
                                            }
                                        }
                                        else if (secim4 == 2)
                                        {
                                            Console.WriteLine("Lütfen Hesap numarası giriniz: ");
                                            long hesap_numarasi = 123456789876;
                                            hesap_numarasi = long.Parse(Console.ReadLine());
                                            if (hesap_numarasi == 123456789876)
                                            {
                                                Console.WriteLine("Lütfen yatırılacak para miktarını giriniz?");
                                                int bakiye = int.Parse(Console.ReadLine());
                                                if (bakiye <= 250)
                                                {
                                                    Console.WriteLine("Para yatırılıyor. İyi günler dileriz.");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Yetersiz bakiye.\nAna menü için 9 \nÇıkmak için 0");
                                                    int secim9 = int.Parse(Console.ReadLine());
                                                    if (secim9 == 9)
                                                    {
                                                        Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                                        continue;
                                                    }
                                                    else if (secim9 == 0)
                                                    {
                                                        Console.WriteLine("İyi günler dileriz.");
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Hatalı seçim yaptınız");
                                                        break;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Hatalı hesap numarası numarası girdiniz.\nAna menü için 9 \nÇıkmak için 0 ");
                                                int secim10 = int.Parse(Console.ReadLine());
                                                if (secim10 == 9)
                                                {
                                                    Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                                    continue;
                                                }
                                                else if (secim10 == 0)
                                                {
                                                    Console.WriteLine("İyi günler dileriz.");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Hatalı seçim yaptınız");
                                                    break;
                                                }
                                            }
                                        }

                                        break;

                                    case 4:

                                        Console.WriteLine("Eğitim ödemeleri bölümü arızalıdır, daha sonra tekrar deneyiniz.\nAna menü için 9 \nÇıkmak için 0  ");
                                        int secim11 = int.Parse(Console.ReadLine());
                                        if (secim11 == 9)
                                        {
                                            Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                            continue;
                                        }
                                        else if (secim11 == 0)
                                        {
                                            Console.WriteLine("İyi günler dileriz.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hatalı seçim yaptınız");
                                            break;
                                        }

                                        break;

                                    case 5:

                                        Console.WriteLine("Hangi faturayı ödemek istersiniz?*\n1-) Elektrik\n2-) Telefon\n3-) İnternet\n4-) Su\n5-) OGS");
                                        int secim12 = int.Parse(Console.ReadLine());

                                        if (secim12 == 1)
                                        {
                                            Console.WriteLine("Elektrik Fatura miktarınız giriniz:\n");
                                            int bakiye = int.Parse(Console.ReadLine());
                                            if (bakiye <= 250)
                                            {
                                                Console.WriteLine("Para yatırılıyor. İyi günler dileriz.");
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Yetersiz bakiye.\nAna menü için 9 \nÇıkmak için 0");
                                                int secim13 = int.Parse(Console.ReadLine());
                                                if (secim13 == 9)
                                                {
                                                    Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                                    continue;
                                                }
                                                else if (secim13 == 0)
                                                {
                                                    Console.WriteLine("İyi günler dileriz.");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Hatalı seçim yaptınız");
                                                    break;
                                                }
                                            }

                                        }
                                        else if (secim12 == 2)
                                        {
                                            Console.WriteLine("Telefon Fatura miktarınız giriniz:\n");
                                            int bakiye = int.Parse(Console.ReadLine());
                                            if (bakiye <= 250)
                                            {
                                                Console.WriteLine("Para yatırılıyor. İyi günler dileriz.");
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Yetersiz bakiye.\nAna menü için 9 \nÇıkmak için 0");
                                                int secim13 = int.Parse(Console.ReadLine());
                                                if (secim13 == 9)
                                                {
                                                    Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                                    continue;
                                                }
                                                else if (secim13 == 0)
                                                {
                                                    Console.WriteLine("İyi günler dileriz.");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Hatalı seçim yaptınız");
                                                    break;
                                                }
                                            }

                                        }
                                        else if (secim12 == 3)
                                        {
                                            Console.WriteLine("İnternet Fatura miktarınız giriniz:\n");
                                            int bakiye = int.Parse(Console.ReadLine());
                                            if (bakiye <= 250)
                                            {
                                                Console.WriteLine("Para yatırılıyor. İyi günler dileriz.");
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Yetersiz bakiye.\nAna menü için 9 \nÇıkmak için 0");
                                                int secim13 = int.Parse(Console.ReadLine());
                                                if (secim13 == 9)
                                                {
                                                    Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                                    continue;
                                                }
                                                else if (secim13 == 0)
                                                {
                                                    Console.WriteLine("İyi günler dileriz.");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Hatalı seçim yaptınız");
                                                    break;
                                                }
                                            }

                                        }
                                        else if (secim12 == 4)
                                        {
                                            Console.WriteLine("Su Fatura miktarınız giriniz:\n");
                                            int bakiye = int.Parse(Console.ReadLine());
                                            if (bakiye <= 250)
                                            {
                                                Console.WriteLine("Para yatırılıyor. İyi günler dileriz.");
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Yetersiz bakiye.\nAna menü için 9 \nÇıkmak için 0");
                                                int secim13 = int.Parse(Console.ReadLine());
                                                if (secim13 == 9)
                                                {
                                                    Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                                    continue;
                                                }
                                                else if (secim13 == 0)
                                                {
                                                    Console.WriteLine("İyi günler dileriz.");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Hatalı seçim yaptınız");
                                                    break;
                                                }
                                            }

                                        }
                                        else if (secim12 == 5)
                                        {
                                            Console.WriteLine("OGS Fatura miktarınız giriniz:\n");
                                            int bakiye = int.Parse(Console.ReadLine());
                                            if (bakiye <= 250)
                                            {
                                                Console.WriteLine("Para yatırılıyor. İyi günler dileriz.");
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Yetersiz bakiye.\nAna menü için 9 \nÇıkmak için 0");
                                                int secim13 = int.Parse(Console.ReadLine());
                                                if (secim13 == 9)
                                                {
                                                    Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                                    continue;
                                                }
                                                else if (secim13 == 0)
                                                {
                                                    Console.WriteLine("İyi günler dileriz.");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Hatalı seçim yaptınız");
                                                    break;
                                                }
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Hatalı numara tuşadınız. \nAna menü için 9 \nÇıkmak için 0 ");
                                            int secim14 = int.Parse(Console.ReadLine());
                                            if (secim14 == 9)
                                            {
                                                Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                                continue;
                                            }
                                            else if (secim14 == 0)
                                            {
                                                Console.WriteLine("İyi günler dileriz.");
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Hatalı seçim yaptınız");
                                                break;
                                            }
                                        }

                                        break;

                                    case 6:

                                        Console.WriteLine("Şifrenizi değiştirmek istiyor musunuz?\nEvet için 1\nAna menü için 9 \nÇıkmak için 0 ");
                                        int secim15 = int.Parse(Console.ReadLine());

                                        if (secim15 == 1)
                                        {
                                            Console.WriteLine("Lütfen yeni şifrenizi giriniz: ");
                                            string yeni_sifre = Console.ReadLine();
                                            Console.WriteLine("Lütfen yeni şifrenizi tekrar giriniz: ");
                                            string yeni_sifre_tekrar = Console.ReadLine();
                                            if (yeni_sifre == yeni_sifre_tekrar)
                                            {
                                                sifre = yeni_sifre;
                                                Console.WriteLine("Şifreniz değiştirildi. Yeni Şifreniz:" + yeni_sifre + " Ana menüye yönlendiriliyorsunuz");
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Hatalı şiifre tuşladınız.\nEvet için 1\nAna menü için 9 \nÇıkmak için 0");
                                                int secim16 = int.Parse(Console.ReadLine());
                                                if (secim16 == 9)
                                                {
                                                    Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                                    continue;
                                                }
                                                else if (secim16 == 0)
                                                {
                                                    Console.WriteLine("İyi günler dileriz.");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Hatalı seçim yaptınız");
                                                    break;
                                                }
                                            }
                                        }
                                        else if (secim15 == 9)
                                        {
                                            Console.WriteLine("Ana Menüye yönlendiriliyorsunuz");
                                            continue;
                                        }
                                        else if (secim15 == 0)
                                        {
                                            Console.WriteLine("İyi günler dileriz.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hatalı seçim yaptınız");
                                            break;
                                        }

                                        break;


                                }
                                break;


                            }
                            else
                            {
                                Console.WriteLine("Kullanıcı adı veya şifre hatalı lütfen Tekrar deneyiniz!");
                            }

                            hak--;
                            Console.WriteLine("\nKalan Hakkınız: " + hak);
                        }





                    }
                }
                else
                {
                    Console.WriteLine("Hatalı seçim yaptınız");
                }
            }

            else
            {
                Console.WriteLine("Hatalı seçim yaptınız");
            }


            Console.Read();
        }
    }
}

