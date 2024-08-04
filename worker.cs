using System;

public class Calisan
{
    public string unvan;
    public double maas;

    
    public Calisan()
    {
    }
}

public class GenelMudur : Calisan
{
    public GenelMudur()
    {
        unvan = "Genel Müdür";
        maas = 80000.0;
    }
}

public class Mudur : Calisan
{
    public Mudur()
    {
        unvan = "Müdür";
        maas = 60000.0;
    }
}

public class Programci : Calisan
{
    public Programci()
    {
        unvan = "Programcı";
        maas = 40000.0;
    }
}

public class Stajyer : Calisan
{
    public Stajyer()
    {
        unvan = "Stajyer";
        maas = 5000.0;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
      
        GenelMudur genelMudur = new GenelMudur();
        Mudur mudur = new Mudur();
        Programci programci = new Programci();
        Stajyer stajyer = new Stajyer();

        
        double toplamMaas = genelMudur.maas + mudur.maas + programci.maas + stajyer.maas;

        
        Console.WriteLine("Çalışanların toplam maaşı: " + toplamMaas + " TL");
    }
}
