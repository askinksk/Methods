internal static class Program
{

    public static void Main(string[] args)
    {
        //Console.WriteLine("Adınızı Giriniz :");
        //string ad=Console.ReadLine();
        //bilgi(ad);

        //int alinanyol, zaman;
        //Console.WriteLine("Gidilen kilometreyi giriniz....:");
        //alinanyol=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Gittiğiniz süreyi giriniz......:");
        //zaman=Convert.ToInt32(Console.ReadLine());
        //hiz(alinanyol, zaman);
        //Console.ReadKey();



        int KalanSarj, harcananSarj;
        decimal gecenSure, disardaGecilecekSure;
        Console.WriteLine("Şarjınızı Giriniz...:");
        KalanSarj = Convert.ToInt16(Console.ReadLine());
        if (KalanSarj <= 0)
        {
            Console.WriteLine("Telefonunuz kapalıdır...");
        }
        else
        {
            Console.WriteLine("Telefonu kullanma sürenizi giriniz.....:");
            gecenSure = Convert.ToDecimal(Console.ReadLine());

            if (gecenSure == 0)
            {
                Console.WriteLine("Şarjınız :" + KalanSarj);
                Console.ReadLine();
            }
            else if (gecenSure < 0)
            {
                Console.WriteLine("Hatalı giriş yaptınız..");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Telefonunuzu kaç saat şarja takmadan kullanacaksınız.....(Telefonu prizden çıkartma anınızdan itibaren):");
                disardaGecilecekSure = Convert.ToDecimal(Console.ReadLine());
                if (disardaGecilecekSure == 0)
                {
                    Console.WriteLine("Şarjınız :" + KalanSarj);
                    Console.ReadLine();
                }
                else if (disardaGecilecekSure < 0)
                {
                    Console.WriteLine("Hatalı giriş yaptınız..");
                    Console.ReadLine();
                }
                else
                {

                    harcananSarj = 100 - KalanSarj;

                    decimal harcanılacakSarj = (harcananSarj / gecenSure) * disardaGecilecekSure;
                    decimal sonuc = 100 - harcanılacakSarj;

                    if (sonuc > 0 && gecenSure<disardaGecilecekSure)
                    {
                        Console.WriteLine("Gün sonunda ortalama şarjınız :" + sonuc);
                    }
                    else
                    {
                        Console.WriteLine("Telefonunuz kapanacaktır...");
                    }

                }
            }
        }
    }
    //static void bilgi(string ad)
    //{
    //    Console.WriteLine("Hoşgeldin " + ad);
    //}
    //static void hiz(int yol,int sure)
    //{
    //    Console.WriteLine("Aracın ortalama hızı {0} KM/S", yol / sure);
    //}
    //public class OrtalamaSarj
    //{
    //    public int Sonuc()
    //    {
    //        return (GecenSure / HarcananSarj) * DisardaGecenSure;
    //    }
    //    public int DisardaGecilecekSure(int disardaGecilecekSure)
    //    {
    //        return disardaGecilecekSure;
    //    }
    //    public int GecenSure(int gecenSure)
    //    {
    //        return gecenSure;
    //    }
    //    public int HarcananSarj(int harcananSarj)
    //    {
    //        return 100 - harcananSarj;
    //    }
    //}
}