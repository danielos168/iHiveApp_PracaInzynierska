using Newtonsoft.Json;
namespace iHiveApp
{
    public class Bilans
    {
        public DateTime data_dodania { get; set; } = DateTime.Now;
        public Ul ul { get; set; }
        
        public Pasieka pasieka { get; set; }

        public string Rodzaj { get; set; }

        public double ilosc { get; set; }

        public Bilans(DateTime data_dodania, Pasieka pasieka, string rodzaj, double ilosc)
        {
            this.data_dodania = data_dodania;
            this.pasieka = pasieka;
            this.Rodzaj = rodzaj;
            this.ilosc = ilosc;
        }

        public Bilans(DateTime data_dodania, Ul ul, string rodzaj)
        {
            this.data_dodania = data_dodania;
            this.ul = ul;
            this.Rodzaj = rodzaj;
            this.ilosc = ilosc;
        }
    }
}

