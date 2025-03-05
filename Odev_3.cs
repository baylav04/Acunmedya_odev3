//soru1

//using System;

//class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public double Salary { get; set; }
//    public string Department { get; set; }

//    public Employee(int id, string name, double salary, string department)
//    {
//        Id = id;
//        Name = name;
//        Salary = salary;
//        Department = department;
//    }

//    public virtual double CalculateBonus()
//    {
//        return 0; 
//    }
//}

//class Manager : Employee
//{
//    public int TeamSize { get; set; }

//    public Manager(int id, string name, double salary, string department, int teamSize)
//        : base(id, name, salary, department)
//    {
//        TeamSize = teamSize;
//    }

//    public override double CalculateBonus()
//    {
//        return Salary * 0.2; 
//    }
//}

//class Developer : Employee
//{
//    public string About { get; set; }

//    public Developer(int id, string name, double salary, string department, string about)
//        : base(id, name, salary, department)
//    {
//        About = about;
//    }

//    public override double CalculateBonus()
//    {
//        return Salary * 0.1;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Manager manager = new Manager(1, "Kadriye", 10000, "IT", 5);
//        Developer developer = new Developer(2, "Arzu", 8000, "IT", "Backend Developer");

//        Console.WriteLine($"Manager {manager.Name}'s Bonus: {manager.CalculateBonus()}");
//        Console.WriteLine($"Developer {developer.Name}'s Bonus: {developer.CalculateBonus()}");
//    }
//}



//soru2

//using System;

//class BankAccount
//{
//    public string AccountHolder { get; set; }
//    public double Balance { get; set; }

//    public BankAccount(string accountHolder, double balance)
//    {
//        AccountHolder = accountHolder;
//        Balance = balance;
//    }

//    public virtual void CalculateInterest()
//    {

//    }
//}

//class SavingsAccount : BankAccount
//{
//    public SavingsAccount(string accountHolder, double balance) : base(accountHolder, balance) { }

//    public override void CalculateInterest()
//    {
//        double interest = Balance * 0.05; 
//        Console.WriteLine($"Savings Account Interest for {AccountHolder}: {interest}");
//    }
//}

//class CheckingAccount : BankAccount
//{
//    public CheckingAccount(string accountHolder, double balance) : base(accountHolder, balance) { }

//    public override void CalculateInterest()
//    {
//        Console.WriteLine("Checking accounts do not earn interest.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount savings = new SavingsAccount("Kadriye", 10000);
//        BankAccount checking = new CheckingAccount("Arzu", 5000);

//        savings.CalculateInterest();
//        checking.CalculateInterest();
//    }
//}


//soru5

//using System;

//abstract class YemekHazirlama
//{
//    public void MalzemeleriHazirla()
//    {
//        Console.WriteLine("Malzemeler hazırlanıyor...");
//    }

//    public abstract void Pisir();

//    public void ServisEt()
//    {
//        Console.WriteLine("Yemek servise hazır.");
//    }
//}

//class PizzaYapici : YemekHazirlama
//{
//    public override void Pisir()
//    {
//        Console.WriteLine("Pizza fırında pişiriliyor.");
//    }
//}

//class SalataYapici : YemekHazirlama
//{
//    public override void Pisir()
//    {
//        Console.WriteLine("Salata için sadece malzemeler karıştırılıyor, pişirme yok.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        YemekHazirlama pizza = new PizzaYapici();
//        YemekHazirlama salata = new SalataYapici();

//        pizza.MalzemeleriHazirla();
//        pizza.Pisir();
//        pizza.ServisEt();

//        Console.WriteLine();

//        salata.MalzemeleriHazirla();
//        salata.Pisir();
//        salata.ServisEt();
//    }
//}

//2
//using System;

//abstract class AkilliCihaz
//{
//    public string CihazAdi { get; set; }

//    public void Ac()
//    {
//        Console.WriteLine($"{CihazAdi} açıldı.");
//    }

//    public void Kapat()
//    {
//        Console.WriteLine($"{CihazAdi} kapatıldı.");
//    }

//    public abstract void WiFiBaglan();
//}

//class AkilliTelefon : AkilliCihaz
//{
//    public AkilliTelefon(string ad) { CihazAdi = ad; }

//    public override void WiFiBaglan()
//    {
//        Console.WriteLine($"{CihazAdi}, 5GHz WiFi ağına bağlanıyor.");
//    }
//}

//class AkilliSaat : AkilliCihaz
//{
//    public AkilliSaat(string ad) { CihazAdi = ad; }

//    public override void WiFiBaglan()
//    {
//        Console.WriteLine($"{CihazAdi}, Bluetooth üzerinden internete bağlanıyor.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        AkilliCihaz telefon = new AkilliTelefon("Samsung Galaxy S24");
//        AkilliCihaz saat = new AkilliSaat("Apple Watch");

//        telefon.Ac();
//        telefon.WiFiBaglan();

//        saat.Ac();
//        saat.WiFiBaglan();
//    }
//}

//3
//using System;

//interface ITasimacilik
//{
//    void Baslat();
//    void Durdur();
//    void HizHesapla();
//}

//class Araba : ITasimacilik
//{
//    public void Baslat() => Console.WriteLine("Araba motoru çalıştı.");
//    public void Durdur() => Console.WriteLine("Araba motoru durdu.");
//    public void HizHesapla() => Console.WriteLine("Araba hızı GPS ile hesaplanıyor.");
//}

//class Bisiklet : ITasimacilik
//{
//    public void Baslat() => Console.WriteLine("Bisiklet sürüşü başladı.");
//    public void Durdur() => Console.WriteLine("Bisiklet sürüşü durdu.");
//    public void HizHesapla() => Console.WriteLine("Bisiklet hızı pedal dönüşleri ile hesaplanıyor.");
//}

//class Gemi : ITasimacilik
//{
//    public void Baslat() => Console.WriteLine("Gemi motoru çalıştı.");
//    public void Durdur() => Console.WriteLine("Gemi motoru durdu.");
//    public void HizHesapla() => Console.WriteLine("Gemi hızı su akıntısı ölçümleriyle hesaplanıyor.");
//}

//class Program
//{
//    static void Main()
//    {
//        ITasimacilik araba = new Araba();
//        ITasimacilik bisiklet = new Bisiklet();
//        ITasimacilik gemi = new Gemi();

//        araba.Baslat();
//        araba.HizHesapla();
//        araba.Durdur();

//        Console.WriteLine();

//        bisiklet.Baslat();
//        bisiklet.HizHesapla();
//        bisiklet.Durdur();

//        Console.WriteLine();

//        gemi.Baslat();
//        gemi.HizHesapla();
//        gemi.Durdur();
//    }
//}

//4

//using System;

//interface ISesEfekti
//{
//    void SesCal();
//}

//class Silah : ISesEfekti
//{
//    public void SesCal()
//    {
//        Console.WriteLine("Silah sesi: Bang! Bang!");
//    }
//}

//class Patlama : ISesEfekti
//{
//    public void SesCal()
//    {
//        Console.WriteLine("Patlama sesi: BOOM!");
//    }
//}

//class Karakter : ISesEfekti
//{
//    public void SesCal()
//    {
//        Console.WriteLine("Karakter sesi: Hey! Dikkat et!");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        ISesEfekti silah = new Silah();
//        ISesEfekti patlama = new Patlama();
//        ISesEfekti karakter = new Karakter();

//        silah.SesCal();
//        patlama.SesCal();
//        karakter.SesCal();
//    }
//}