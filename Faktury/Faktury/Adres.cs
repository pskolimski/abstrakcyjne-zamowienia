namespace Faktury
{
    /************************************************
    klasa:      Adres
    opis:       Klasa przechowująca informacje o adresie
                klienta
    pola:       Ulica - ulica zamieszkania
                KodPocztowy - kod pocztowy
                Miasto - miasto zamieszkania
    autor:      Patryk Skolimowski
    ************************************************/
    public class Adres
    {
        public string Ulica { get; }
        public string KodPocztowy { get; }
        public string Miasto { get; }

        public Adres(string ulica, string kodPocztowy, string miasto)
        {
            Ulica = ulica;
            KodPocztowy = kodPocztowy;
            Miasto = miasto;
        }

        /**********************************************
        nazwa funkcji: WyswietlAdres
        opis funkcji: Funkcja wyświetlająca adres klienta
        parametry: brak
        zwracany typ i opis: void
        autor: Patryk Skolimowski
        ***********************************************/
        public void WyswietlAdres()
        {
            Console.WriteLine($"{Ulica}, {KodPocztowy} {Miasto}");
        }
    }
}