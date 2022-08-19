//vücut kit endeksi alıp doktorlara yardımcı olmaya calısan program 
// vkı = kg/ boyun karesi
public class doktorayardim
{
    struct VucutKitleEndeksi
    {
        public double hastanınKilosu;
        public double hastanınBoyu;
        public string hastanınTeshisi;
        public string hastanınAdi;
        public string hastanınSoyadi;

        public double endeks()
        {
            return ((hastanınKilosu) / (hastanınBoyu * hastanınBoyu));


        }


        public string KoyulanTeshis()
        {
            if (endeks() < 18.49)
            {
                return "Zayif";
            }
            else if (18.5 < endeks() && 24.99 > endeks())
            {
                return "İdeal";
            }
            else if (24.99 < endeks() && 29.99 > endeks())
            {
                return "Hafif Kilolu";
            }
            else if (30 < endeks())
            {
                return "OBEZ";
            }
            else
            {
                return "Problem var ";
            }
        }
        public void EkranaYaz()
        {
            Console.Clear();
            Console.WriteLine($"Hastanın ADI : {hastanınAdi} ");
            
            Console.WriteLine($"Hastanın SOYADI :{hastanınSoyadi} ");
            
            Console.WriteLine($"Hastanın Kilosu :{hastanınKilosu} ");
            
            Console.WriteLine($"Hastanın Boyu : {hastanınBoyu}");
           
            Console.WriteLine($"Hastanın Vücut Kitle Endeksi : {endeks()}");
            Console.WriteLine($"Hastanın Teşhisi : {KoyulanTeshis()}");
            

        }
    }

    static List<VucutKitleEndeksi> VKIList = new List<VucutKitleEndeksi>();

    public static void Main()
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("1.Yeni Hasta \n 2.Hasta Listesi \n 3.Çıkış");
        MenuSelection();
    }

   static void MenuSelection()
    {
        Console.WriteLine("Yapılacak İşlemi Seçin : ");
        string choose = Console.ReadLine();
        switch (choose)
        {
            case "1":
                NewVKI();
                break;
            case "2":
                ListOfVKI();
                break;
            case "3":
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Hatalı Seçim.Tekrar Deneyiniz.");
                MenuSelection();
                break;
        }
    }
    static void ListOfVKI()
    {
        Console.Clear();
        foreach (var vki in VKIList)
        {
           
            vki.EkranaYaz();
            Console.WriteLine("----------------------------.");
        }
        Again();
    }
    static void NewVKI()
    {
        VucutKitleEndeksi v = new VucutKitleEndeksi();

        Console.WriteLine($"Hastanın ADI : ");
        v.hastanınAdi = Console.ReadLine();
        Console.WriteLine($"Hastanın SOYADI : ");
        v.hastanınSoyadi = Console.ReadLine();
        Console.WriteLine($"Hastanın Kilosu : ");
        v.hastanınKilosu = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Hastanın Boyu : ");
        v.hastanınBoyu = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Hastanın Vücut Kitle Endeksi : {v.endeks()}");
        
        Console.WriteLine($"Hastanın Teşhisi : {v.KoyulanTeshis()}");
        VKIList.Add(v);
        Again();
       

    }
    static void Again()
    {
        Console.WriteLine("Menüye Dönmek İçin ENTER");
        Console.ReadLine();
        Menu();
    }
}


