using Newtonsoft.Json;
namespace iHiveApp
{
    public class Pasieka
    {
        public string nazwa;
        public double lokalizacjaX { get; set; }
        public double lokalizacjaY { get; set; }
        public List<Ul> lista_uli { get; set; }
        public DateTime data_zalozenia { get; }
        public Pasieka()
        {

        }
        public Pasieka(string nazwa)
        {
            this.nazwa = nazwa;
        }
        public Pasieka(string nazwa, double lokalizacjaX, double lokalizacjaY, DateTime data_zalozenia)
        {
            this.nazwa = nazwa;
            this.lokalizacjaX = lokalizacjaX;
            this.lokalizacjaY = lokalizacjaY;
            this.data_zalozenia = data_zalozenia;
        }

        public string JsonSerialize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

