namespace Faktury
{
    class Program
    {
        static void Main(string[] args)
        {
            var adres1 = new Adres("Ulica 1", "00-001", "Miasto 1");
            var klient1 = new Klient("Jan", "Kowalski", adres1);

            var adres2 = new Adres("Ulica 2", "00-002", "Miasto 2");
            var klient2 = new Klient("Anna", "Nowak", adres2);

            var zamowienie1 = new ZamowienieProdukt(1, DateTime.Now, klient1, "Produkt 1", 10.0, 5);
            var zamowienie2 = new ZamowienieUsluga(2, DateTime.Now, klient2, "Usługa 1", 50.0, 2);

            var magazyn = new MagazynZamowien();
            magazyn.DodajZamowienie(zamowienie1);
            magazyn.DodajZamowienie(zamowienie2);

            magazyn.WyswietlWszystkieZamowienia();

            try
            {
                double totalCost = magazyn.ObliczKosztCalkowity();
                Console.WriteLine($"Łączny koszt: {totalCost}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd przy obliczaniu łącznego kosztu: {ex.Message}");
            }

            var faktura = new Faktura(1, DateTime.Now);
            faktura.DodajZamowienieDoFaktury(zamowienie1);
            faktura.DodajZamowienieDoFaktury(zamowienie2);
            faktura.GenerujFakture();
        }
    }
}