using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        // Değer döndürmeyen bir metodu çağırma
        Greeting();
        Console.WriteLine("------------------------------------------------");
        // Rastgele sayı üretip 2'ye bölümünden kalanı hesaplayan metodu çağırma
        int remainder = rndnbr();
        Console.WriteLine("2'ye bölümünden kalan: " + remainder);

        Console.WriteLine("------------------------------------------------");

        // Çarpım Hesaplamak İçin iki sayı belirliyoruz
        Console.WriteLine("lütfen iki değer giriniz");
        int say1 = Convert.ToInt32(Console.ReadLine());
        int say2 = Convert.ToInt32(Console.ReadLine()); 
        // Multiply metodu çağırılarak çarpımı hesaplıyoruz
        int carp = carpım(say1, say2);
        Console.WriteLine(say1 + " ve " +say2 + " nin çarpımı :" + carp );

        Console.WriteLine("------------------------------------------------");
        Console.Write("Lütfen adınız ve soyadınızı giriniz :");
        // İsim ve soyisim bilgilerini belirliyoruz
        string ad = Console.ReadLine();
        string soyad = Console.ReadLine();
        // GreetUser metodu çağrılarak mesaj ekrana basılıyor
        kullanici(ad, soyad);


    }

    // Değer döndürmeyen bir metot tanımlama
    static void Greeting()
    {
        Console.WriteLine("J'lui ai dit \"Aime-moi?\" Prends-moi dans tes bras, je n'ai plus personne");
        
    }
    static int rndnbr()
    {
        // Rastgele sayı üretici nesnesini oluşturuyoruz
        Random random = new Random();
        // Rastgele bir sayı üretiyoruz
        int randomNumber = random.Next();
        // Bu sayının 2'ye bölümünden kalanı döndürüyoruz
        return randomNumber % 2;
    }

    static int carpım(int say1, int say2)
    {
        return say1 * say2;
    }

    static void kullanici(string ad, string soyad)
    {
        Console.WriteLine($"Hoş Geldiniz {ad} {soyad}");
    }

}
