using Newtonsoft.Json;
namespace iHiveApp
{
    public class Zadanie
    {
        public DateTime data_zadania { get; set; } = DateTime.Now;
        public Ul ul { get; set; }
        
        public Pasieka pasieka { get; set; }

        public string zadanie { get; set; }

        public Zadanie(DateTime data_zadania, Pasieka pasieka, string zadanie)
        {
            this.data_zadania = data_zadania;
            this.pasieka = pasieka;
            this.zadanie = zadanie;
        }

        public Zadanie(DateTime data_zadania, Ul ul, string zadanie)
        {
            this.data_zadania = data_zadania;
            this.ul = ul;
            this.zadanie = zadanie;
        }
    }
}

