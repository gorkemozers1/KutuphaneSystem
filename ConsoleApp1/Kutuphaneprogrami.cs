using System;
using System.Collections.Generic;

public class Kitap
{
    public int KitapID { get; set; }
    public string KitapAdi { get; set; }
    public string Yazar { get; set; }
    public int YayinYili { get; set; }
}

public class Kutuphane
{
    private List<Kitap> kitaplar;

    public Kutuphane()
    {
        kitaplar = new List<Kitap>();
    }

    public void KitapEkle(Kitap yeniKitap)
    {
        kitaplar.Add(yeniKitap);
    }

    public void KitapSil(int kitapID)
    {
        Kitap silinecekKitap = kitaplar.Find(k => k.KitapID == kitapID);
        if (silinecekKitap != null)
        {
            kitaplar.Remove(silinecekKitap);
            Console.WriteLine("Kitap başarıyla silindi.");
        }
        else
        {
            Console.WriteLine("Kitap bulunamadı.");
        }
    }

    public Kitap KitapAra(int kitapID)
    {
        return kitaplar.Find(k => k.KitapID == kitapID);
    }

    public void TumKitaplariListele()
    {
        Console.WriteLine("Kütüphanede bulunan kitaplar:");
        foreach (var kitap in kitaplar)
        {
            Console.WriteLine($"ID: {kitap.KitapID}, Adı: {kitap.KitapAdi}, Yazar: {kitap.Yazar}, Yayın Yılı: {kitap.YayinYili}");
        }
    }

    public List<Kitap> YazarKitaplariListele(string yazar)
    {
        List<Kitap> yazarinKitaplari = kitaplar.FindAll(k => k.Yazar == yazar);
        if (yazarinKitaplari.Count == 0)
        {
            Console.WriteLine("Bu yazarın kitapları bulunamadı.");
        }
        else
        {
            Console.WriteLine($"{yazar} adlı yazarın kitapları:");
            foreach (var kitap in yazarinKitaplari)
            {
                Console.WriteLine($"ID: {kitap.KitapID}, Adı: {kitap.KitapAdi}, Yayın Yılı: {kitap.YayinYili}");
            }
        }
        return yazarinKitaplari;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kutuphane kutuphane = new Kutuphane();

        Kitap kitap1 = new Kitap() { KitapID = 1, KitapAdi = "Sefiller", Yazar = "Victor Hugo", YayinYili = 1862 };
        Kitap kitap2 = new Kitap() { KitapID = 2, KitapAdi = "1984", Yazar = "George Orwell", YayinYili = 1949 };
        Kitap kitap3 = new Kitap() { KitapID = 3, KitapAdi = "Harry Potter and the Philosopher's Stone", Yazar = "J.K. Rowling", YayinYili = 1997 };
        Kitap kitap4 = new Kitap() { KitapID = 4, KitapAdi = "Yeraltından Notlar" , Yazar = "Fyodor Dostoyevski", YayinYili = 1864 };
        Kitap kitap5 = new Kitap() { KitapID = 5, KitapAdi = "1984", Yazar = "George Orwell", YayinYili = 1949};
        Kitap kitap6 = new Kitap() { KitapID = 6, KitapAdi = "Sefiller", Yazar = "Victor Hugo", YayinYili = 1862 };
        Kitap kitap7 = new Kitap() { KitapID = 7, KitapAdi = "Beyaz Diş", Yazar = "Jack London", YayinYili = 1906 };
        Kitap kitap8 = new Kitap() { KitapID = 8, KitapAdi = "Savaş ve Barış", Yazar = "Lev Tolstoy", YayinYili = 1869 };
        Kitap kitap9 = new Kitap() { KitapID = 9, KitapAdi = "Küçük Prens ", Yazar = "Antoine de Saint-Exupéry ", YayinYili = 1943 };
        Kitap kitap10 = new Kitap() { KitapID = 10, KitapAdi = "Ulysses", Yazar = "", YayinYili = 1915 };
        Kitap kitap11 = new Kitap() { KitapID = 11, KitapAdi = "Dönüşüm", Yazar = "", YayinYili = 1605 };
        Kitap kitap12 = new Kitap() { KitapID = 12, KitapAdi = "Don Quijote", Yazar = " ", YayinYili = 1997 };
        Kitap kitap13= new Kitap() { KitapID = 13, KitapAdi = "Anna Karenina", Yazar = "Lev Tolstoy", YayinYili = 1877};
        Kitap kitap14  = new Kitap() { KitapID = 14 , KitapAdi = "Olasılıksız", Yazar = "Adam Fawer", YayinYili = 2001 };


        kutuphane.KitapEkle(kitap1);
        kutuphane.KitapEkle(kitap2);
        kutuphane.KitapEkle(kitap3);

        kutuphane.TumKitaplariListele();

        kutuphane.KitapSil(2);

        kutuphane.TumKitaplariListele();

        kutuphane.YazarKitaplariListele("Victor Hugo");
    }
}
