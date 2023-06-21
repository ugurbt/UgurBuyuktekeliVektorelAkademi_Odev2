using Alistirma.Models;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {


        // Kadrolu Personel
        KadroluPersonel kadrolu = new KadroluPersonel(555, "Uğur", "Büyüktekeli", 9000, 8);
        Console.WriteLine(kadrolu.IsımGetir());
        Console.WriteLine(kadrolu.AylikHesapla());

        // Sözleşmeli Personel
        SozlesmeliPersonel sozlesmeli = new SozlesmeliPersonel(347, "Arda", "Güler", 8.5, 255.5);
        Console.WriteLine(sozlesmeli.IsımGetir());
        Console.WriteLine(sozlesmeli.AylikHesapla());

        // Stajyer Personel
        StajyerPersonel stajyer = new StajyerPersonel(258, "Mustafa", "Aktaş", 6.5, 115.7);
        Console.WriteLine(stajyer.IsımGetir());
        Console.WriteLine(stajyer.AylikHesapla());

        Console.ReadLine();
    }
}





