using Newtonsoft.Json;
namespace iHiveApp
{
    public class Zadanie
    {
        public DateTime? data_zadania { get; set; } = DateTime.Now;
        public string ul { get; set; }
        
        public string cel { get; set; }

        public string zadanie { get; set; }

        public Zadanie(DateTime? data_zadania, string cel, string zadanie)
        {
            this.data_zadania = data_zadania;
            this.cel = cel;
            this.zadanie = zadanie;
        }
        public string JsonSerialize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

