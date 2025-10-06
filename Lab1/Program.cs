using System.Reflection.Metadata;

class Program
{
    public static void Main()
    {
        Console.WriteLine("To jest ćwiczenie 1");
        
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Podaj nazwę:");
            string nazwa = Console.ReadLine();
            Console.WriteLine("Podaj gatunek:");
            string gatunek = Console.ReadLine();
            Console.WriteLine("Podaj liczbę nóg:");
            int liczbaNog = int.Parse(Console.ReadLine());
            Zwierze z = new Zwierze(nazwa, gatunek, liczbaNog);

        }
        Zwierze z = new Zwierze(string "Michał", Zwierze z);
        Console.WriteLine("Liczba zwierząt: " + Zwierze.getLiczbaZwierzat());

    }
}
class Zwierze
{
    private string nazwa;
    private string gatunek;
    private int liczbaNog;
    private static int liczbaZwierzat;

    public string getNazwa()
    {
        return nazwa;
    }
    public string getGatunek()
    {
        return gatunek;
    }
    public int getLiczbaNog()
    {
        return liczbaNog;
    }
  
    public static int getLiczbaZwierzat()
    {
        return liczbaZwierzat;
    }

    public void setNazwa(string i)
    {
        nazwa = i;
    }
    public Zwierze()
    {
        nazwa = "Rex";
        gatunek = "Pies";
        liczbaNog = 4;
        liczbaZwierzat++;
    }
    public Zwierze(string n, string g, int l)
    {
        nazwa = n;
        gatunek = g;
        liczbaNog = l;
        liczbaZwierzat++;
    }
    
    public Zwierze(string nazwa1,Zwierze x)
    {
        nazwa = nazwa1;
        gatunek = x.gatunek;
        liczbaNog = x.liczbaNog;
        liczbaZwierzat++;
    }

    



}