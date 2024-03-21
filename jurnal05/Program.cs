using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Penjumlahan.JumlahTigaAngka<float>((float)1.3, (float)0.2, (float)2.2));
    }
}

class Penjumlahan
{
   public static T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        return (dynamic) angka1 + (dynamic) angka2 + (dynamic) angka3;
    }        
}
