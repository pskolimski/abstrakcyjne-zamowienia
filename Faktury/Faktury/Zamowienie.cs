namespace Faktury
{
    /************************************************
   klasa:      Zamowienie
   opis:       Klasa abstrakcyjna przechowująca informacje o zamówieniu
               składanym przez klienta
   pola:       NumerZamowienia - numer zamówienia
               DataZlozenia - data złożenia zamówienia
               Klient - klient składający zamówienie
   autor:      Patryk Skolimowski
   ************************************************/
    public abstract class Zamowienie
    {
        public int NumerZamowienia { get; }
        public DateTime DataZlozenia { get; }
        public Klient Klient { get; }

        protected Zamowienie(int numerZamowienia, DateTime dataZlozenia, Klient klient)
        {
            NumerZamowienia = numerZamowienia;
            DataZlozenia = dataZlozenia;
            Klient = klient;
        }

        /**********************************************
        nazwa funkcji: ObliczKoszt
        opis funkcji: Funkcja obliczająca koszt zamówienia
        parametry: brak
        zwracany typ i opis: double - koszt zamówienia
        autor: Patryk Skolimowski
        ***********************************************/
        public abstract double ObliczKoszt();
        
        /**********************************************
        nazwa funkcji: WyswietlSzczegoly
        opis funkcji: Funkcja wyświetlająca szczegóły zamówienia
        parametry: brak
        zwracany typ i opis: void
        autor: Patryk Skolimowski
        ***********************************************/
        public virtual void WyswietlSzczegoly()
        {
            Console.WriteLine($"Zamówienie nr: {NumerZamowienia}, Data: {DataZlozenia}");
            Klient.DaneKlienta();
        }
    }
}