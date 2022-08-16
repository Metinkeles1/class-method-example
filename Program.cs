class Araba
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public bool Otomatik { get; set; }

    public void Start()
    {
        Console.WriteLine($"{this.Marka} {this.Model} çalıştırıldı");
    }

    public void Stop()
    {
        Console.WriteLine($"{this.Marka} {this.Model} stop edildi");
    }

    public void Yavasla()
    {
        Console.WriteLine($"{this.Marka} {this.Model} yavaşlıyor");
    }

    public void Hizlan()
    {
        Console.WriteLine($"{this.Marka} {this.Model} Hızlanıyor");
    }

    public void Menu()
    {
        string komut = "";

        do
        {
            Console.WriteLine("1-Start 2-Hızlan 3-Yavaşla 4-Stop Çıkış: Ç");
            Console.Write("Seçiminiz:");
            komut = Console.ReadLine();

            switch (komut)
            {
                case "1":
                    this.Start();
                    break;
                case "2":
                    this.Hizlan();
                    break;
                case "3":
                    this.Yavasla();
                    break;
                case "4":
                    this.Stop();
                    break;
                default:
                    Console.WriteLine("Uygulamadan Çıkıldı.");
                    break;
            }
        } while (komut != "ç");
    }
}


class Islem
{
    // public int Toplama(int x, int y, int z=0)
    // {
    //     Console.WriteLine("x: " + x);
    //     Console.WriteLine("y: " + y);
    //     Console.WriteLine("z: " + z);
    //     return x + y + z;
    // }

    //*aşırı yüklenmiş methodlar aynı işlevi gören ve birden fazla parametre alan fonksiyonlar.
    public int Toplama(int a, int b)
    {
        return a + b;
    }

    public int Toplama(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main(string[] args)
    {

        var islem = new Islem();

        // Console.WriteLine(islem.Toplama(10, 20, 30));
        // Console.WriteLine(islem.Toplama(y: 20, z: 30, x: 10));//bu şekilde isimlendirme yaptıktan sonra gönderdiğimiz parametrelerin sırasının bi önemi kalmıyor.
        Console.WriteLine(islem.Toplama(20, 30, 10));




        // var opel = new Araba();
        // opel.Marka = "Opel";
        // opel.Model = "Astra";
        // opel.Renk = "Beyaz";
        // opel.Otomatik = true;

        // opel.Start();
        // opel.Hizlan();
        // opel.Yavasla();
        // opel.Menu();

        // var mazda = new Araba();
        // mazda.Marka = "Mazda";
        // mazda.Model = "CX3";
        // mazda.Renk = "Kırmızı";
        // mazda.Otomatik = true;
        // mazda.Menu();
    }
}
