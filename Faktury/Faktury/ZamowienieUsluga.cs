namespace Faktury
{
    /************************************************
   klasa:      ZamowienieUsluga
   opis:       Klasa przechowująca informacje o zamówieniu
               usługi
   pola:       RodzajUslugi - rodzaj usługi
               StawkaZaGodzine - stawka za godzinę
               LiczbaGodzin - liczba godzin
   autor:      Patryk Skolimowski
   ************************************************/
    public class ZamowienieUsluga : Zamowienie
    {
        public string RodzajUslugi { get; }
        public double StawkaZaGodzine { get; }
        public int LiczbaGodzin { get; }

        public ZamowienieUsluga(int numerZamowienia, DateTime dataZlozenia, Klient klient, string rodzajUslugi, double stawkaZaGodzine, int liczbaGodzin)
            : base(numerZamowienia, dataZlozenia, klient)
        {
            if (liczbaGodzin <= 0 || stawkaZaGodzine < 0)
                throw new ArgumentException("Błędne dane usługi!");

            RodzajUslugi = rodzajUslugi;
            StawkaZaGodzine = stawkaZaGodzine;
            LiczbaGodzin = liczbaGodzin;
        }

        public override double ObliczKoszt()
        {
            return StawkaZaGodzine * LiczbaGodzin;
        }

        public override void WyswietlSzczegoly()
        {
            base.WyswietlSzczegoly();
            Console.WriteLine($"Usługa: {RodzajUslugi}, Stawka za godzinę: {StawkaZaGodzine}, Liczba godzin: {LiczbaGodzin}");
        }
    }
}