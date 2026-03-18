namespace NASACLII
{
    public class Program
    {
        static List<Kuldetes> kuldetesLista = new List<Kuldetes>();
        static void Main(string[] args)
        {

            string[] beolvasott = File.ReadAllLines("NASAmissions.txt");
            foreach (var item in beolvasott.Skip(1))
            {
                kuldetesLista.Add(new Kuldetes(item));
            }
            hanyKuldetes();

            //4.feladat
            while (true)
            {
                Console.Write("Adja meg egy küldetés nevének részletét: ");
                string bekertNev = Console.ReadLine();
                bool talalt = false;
                for (int i = kuldetesLista.Count()-1; i >= 0; i--)
                {
                    if (kuldetesLista[i].Nev.ToLower().Contains(bekertNev.ToLower()))
                    {
                        Console.WriteLine($"Talált küldetés: {kuldetesLista[i].Nev}, {kuldetesLista[i].Ev}, {kuldetesLista[i].Celpont}, {(kuldetesLista[i].Sikeres ? "Sikeres" : "Sikertelen")}");
                        talalt = true;
                        break;
                    }                    
                }
                if (talalt==true)
                {
                    break;
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("5. feladat: Küldetések kockázati szintjei: ");
            foreach(var item in kuldetesLista)
            {
                if (item.KockazatiSzint() == "Magas")
                {
                    Console.WriteLine($"{item.Nev}: Magas");
                }
            }

            var legkisebbHasznosTeher = kuldetesLista.MinBy(k => k.HasznosTeher);
            Console.WriteLine($"6. feladat: A legkisebb hasznos teher: {legkisebbHasznosTeher.HasznosTeher}kg ({legkisebbHasznosTeher.Nev})");



        }
        //3. feladat
        public static void hanyKuldetes()
        {
            Console.WriteLine($"3. feladat: {kuldetesLista.Count} küldetés található az állományban.");
        }
    }
}
