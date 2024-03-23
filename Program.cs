class Penjumlahan
{
    public void JumlahTigaAngka<T>(T a, T b, T c)
    {
        dynamic aPurse = a;
        dynamic bPurse = b;
        dynamic cPurse = c;
        Console.WriteLine(aPurse + bPurse + cPurse);
    }

    static void Main(string[] args) {
        Penjumlahan penjumlahan = new Penjumlahan();
        penjumlahan.JumlahTigaAngka(13, 02, 22);
    }
}