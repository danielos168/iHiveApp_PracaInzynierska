using Newtonsoft.Json;
namespace iHiveApp
{
    public class Ul
    {
        public string Nazwa;
        public int Ilosc_ramek { get; set; }
        public string Rasa_pszczol { get; set; }
        public string Kolor_ula { get; set; }
        public DateTime Data_zalozenia { get; set; } = DateTime.Now;
        public DateTime Ostatni_przeglad { get; } = DateTime.Now;
        public DateTime Ostatnia_wymiana_matki { get; set; } = DateTime.Now;
        public string Kolor_matki { get; set; }
        public string Opis { get; set; }
        public string Pasieka { get; set; }
        public Ul()
        {

        }
        public Ul(string Nazwa, string Kolor_ula)
        {
            this.Nazwa = Nazwa;
            this.Kolor_ula = Kolor_ula;
        }
        public Ul(string Nazwa, string Kolor_ula, int Ilosc_ramek, string Rasa_pszczol, DateTime Data_zalozenia, DateTime Ostatni_przeglad,
                  DateTime Ostatnia_wymiana_matki, string Kolor_matki, string Opis)
        {
            this.Nazwa = Nazwa;
            this.Kolor_ula = Kolor_ula;
            this.Ilosc_ramek = Ilosc_ramek;
            this.Rasa_pszczol = Rasa_pszczol;
            this.Data_zalozenia = Data_zalozenia;
            this.Ostatni_przeglad = Ostatni_przeglad;
            this.Ostatnia_wymiana_matki = Ostatnia_wymiana_matki;
            this.Kolor_matki = Kolor_matki;
            this.Opis = Opis;
        }

        public string JsonSerialize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

