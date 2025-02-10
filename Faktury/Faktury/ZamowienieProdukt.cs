namespace Faktury
{
    /************************************************
   klasa:      ZamowienieProdukt
   opis:       Klasa przechowująca informacje o zamówieniu
               produktu w sklepie internetowym
   pola:       NazwaProduktu - nazwa produktu
               CenaJednostkowa - cena jednostkowa produktu
               Ilosc - ilość zamówionego produktu
   autor:      Patryk Skolimowski
   ************************************************/
    public class ZamowienieProdukt : Zamowienie
    {
        public string NazwaProduktu { get; }
        public double CenaJednostkowa { get; }
        public int Ilosc { get; }

        public ZamowienieProdukt(int numerZamowienia, DateTime dataZlozenia, Klient klient, string nazwaProduktu, double cenaJednostkowa, int ilosc)
            : base(numerZamowienia, dataZlozenia, klient)
        {
            if (ilosc <= 0 || cenaJednostkowa < 0)
                throw new ArgumentException("Błędne dane produktu!");

            NazwaProduktu = nazwaProduktu;
            CenaJednostkowa = cenaJednostkowa;
            Ilosc = ilosc;
        }

        public override double ObliczKoszt()
        {
            return CenaJednostkowa * Ilosc;
        }

        public override void WyswietlSzczegoly()
        {
            base.WyswietlSzczegoly();
            Console.WriteLine($"Produkt: {NazwaProduktu}, Cena jednostkowa: {CenaJednostkowa}, Ilość: {Ilosc}");
        }
    }
}