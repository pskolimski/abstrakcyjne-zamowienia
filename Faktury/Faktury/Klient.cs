namespace Faktury
{
    /************************************************
    klasa:      Klient
    opis:       Klasa przechowująca informacje o kliencie
                składającego zamówienie
    pola:       Imie - imię klienta
                Nazwisko - nazwisko klienta
                Adres - adres zamieszkania klienta
    autor:      Patryk Skolimowski
    ************************************************/
    public class Klient
    {
        public string Imie { get; }
        public string Nazwisko { get; }
        public Adres Adres { get; }

        public Klient(string imie, string nazwisko, Adres adres)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Adres = adres;
        }

        /**********************************************
        nazwa funkcji: DaneKlienta
        opis funkcji: Funkcja wyświetlająca dane klienta
        parametry: brak
        zwracany typ i opis: void
        autor: Patryk Skolimowski
        ***********************************************/
        public void DaneKlienta()
        {
            Console.WriteLine($"{Imie} {Nazwisko}");
            Adres.WyswietlAdres();
        }
    }
}