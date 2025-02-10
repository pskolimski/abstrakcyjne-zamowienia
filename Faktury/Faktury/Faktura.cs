namespace Faktury
{
    /************************************************
    klasa:      Faktura
    opis:       Klasa przechowująca informacje o fakturze
    pola:       NumerFaktury - numer faktury
                DataWystawienia - data wystawienia faktury
                zamowienia - lista zamówień na fakturze
    autor:      Patryk Skolimowski
    ************************************************/
    public class Faktura
    {
        public int NumerFaktury { get; }
        public DateTime DataWystawienia { get; }
        private List<Zamowienie> zamowienia = new List<Zamowienie>();

        public Faktura(int numerFaktury, DateTime dataWystawienia)
        {
            NumerFaktury = numerFaktury;
            DataWystawienia = dataWystawienia;
        }

        /**********************************************
        nazwa funkcji: DodajZamowienieDoFaktury
        opis funkcji: Funkcja dodająca zamówienie do faktury
        parametry: brak
        zwracany typ i opis: void
        autor: Patryk Skolimowski
        ***********************************************/
        public void DodajZamowienieDoFaktury(Zamowienie zamowienie)
        {
            zamowienia.Add(zamowienie);
        }

        /**********************************************
        nazwa funkcji: GenerujFakture
        opis funkcji: Funkcja generująca fakturę
        parametry: brak
        zwracany typ i opis: void
        autor: Patryk Skolimowski
        ***********************************************/
        public void GenerujFakture()
        {
            Console.WriteLine($"Faktura nr: {NumerFaktury}, Data: {DataWystawienia}");
            double totalCost = 0;
            foreach (var zamowienie in zamowienia)
            {
                zamowienie.WyswietlSzczegoly();
                totalCost += zamowienie.ObliczKoszt();
            }
            Console.WriteLine($"Suma końcowa: {totalCost}");
        }
    }
}