namespace Dedicnost
{
    class Program
    {
        public static void Main(string[] args)
        {
            Postava [] legie = new Postava[1000];
            ///Postava postava = new Postava("Test", 1);

            legie[0] = new Bojovnik(1, "Olaf", "Sekera");
            legie[1] = new Bojovnik(2, "Ragnar", "Meč");
            legie[2] = new Kouzelnik(3, "Merlin", 100, 100);

            Postava terminator = new Boss("T-800", 24, 1000);
            Bojovnik barbar = new Bojovnik(1, "Olaf", "Sekera");
            Kouzelnik kouzelnik = new Kouzelnik(2, "Merlin", 9, 100);
            FinalBoss finalBoss = new FinalBoss("Darth Vader", 25, 10000, 120);

            List<Postava> postavy = new List<Postava>();
            postavy.Add(new Bojovnik(5, "Rytíř", "Palcát"));
            postavy.Add(new Kouzelnik(6, "Gandalf", 50, 100));
            postavy.Add(new Boss("Sauron", 7, 5000));
            postavy.Add(new FinalBoss("Hans", 8, 10000, 120));
            foreach (Postava p in postavy) p.Utoc();

            finalBoss.VypisInformace();
            finalBoss.PrepniBojovyRezim();
            finalBoss.VypisInformace();
            finalBoss.Utoc();
            finalBoss.VypisInformace();
            
            Console.WriteLine($"Síla útoku: {finalBoss.VypocitejUtok(50)}");

            terminator.Utoc();
            terminator.PredstavSe();
            barbar.PredstavSe();
            barbar.Utoc();
            barbar.ZvedniStit();

            kouzelnik.PredstavSe();
            kouzelnik.Utoc();

            Console.WriteLine(barbar.Jmeno);

            barbar.Jmeno = "Ragnar";
            
            Console.WriteLine(barbar.Jmeno);

            Console.WriteLine(kouzelnik.Mana);

            kouzelnik.Meditovat();

            
        }
    }
}