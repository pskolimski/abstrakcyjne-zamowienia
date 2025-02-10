namespace Faktury
{
    /************************************************
    klasa:      MagazynZamowien
    opis:       Klasa przechowująca informacje o zamówieniach
                składanych przez klientów
    pola:       zamowienia - lista zamówień
    autor:      Patryk Skolimowski
    ************************************************/
    public class MagazynZamowien
    {
        private List<Zamowienie> zamowienia = new List<Zamowienie>();

        /**********************************************
        nazwa funkcji: DodajZamowienie
        opis funkcji: Funkcja dodająca zamówienie do magazynu
        parametry: zamowienie - zamówienie do dodania
        zwracany typ i opis: void
        autor: Patryk Skolimowski
        ***********************************************/
        public void DodajZamowienie(Zamowienie zamowienie)
        {
            zamowienia.Add(zamowienie);
        }

        /**********************************************
        nazwa funkcji: ObliczKosztCalkowity
        opis funkcji: Funkcja obliczająca koszt wszystkich zamówień
        parametry: brak
        zwracany typ i opis: double - koszt wszystkich zamówień
        autor: Patryk Skolimowski
        ***********************************************/
        public double ObliczKosztCalkowity()
        {
            double totalCost = 0;
            foreach (var zamowienie in zamowienia)
            {
                try
                {
                    totalCost += zamowienie.ObliczKoszt();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd przy obliczaniu kosztu zamówienia: {ex.Message}");
                }
            }
            return totalCost;
        }

        /**********************************************
        nazwa funkcji: WyswietlWszystkieZamowienia
        opis funkcji: Funkcja wyświetlająca szczegóły wszystkich zamówień
        parametry: brak
        zwracany typ i opis: void
        autor: Patryk Skolimowski
        ***********************************************/
        public void WyswietlWszystkieZamowienia()
        {
            foreach (var zamowienie in zamowienia)
            {
                zamowienie.WyswietlSzczegoly();
            }
        }
    }
}