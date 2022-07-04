using Newtonsoft.Json;
namespace iHiveApp
{
    public class Przeglad
    {
        public DateTime? data_przegladu { get; set; } = DateTime.Now;

        public int Ile_ramek_miod { get; set; }
        public int Ile_miodu { get; set; }
        public string Jaki_miod { get; set; }
        public int Korpusy { get; set; }
        public int Ramki { get; set; }
        public int Ramki_z_miodem { get; set; }
        public int Ramki_z_czerwiem { get; set; }
        public int Ramki_z_pierzgą { get; set; }
        public int Ramki_z_węzą { get; set; }
        public bool Matka { get; set; }
        public bool Mateczniki { get; set; }
        public bool Jajeczka { get; set; }
        public bool Czerw_otwarty { get; set; }
        public bool Czerw_zasklepiony { get; set; }
        public bool Czerw_trutowy { get; set; }
        public bool Nakrop { get; set; }
        public bool Miód_zasklepiony { get; set; }
        public bool Pierzga { get; set; }
        public string Sila { get; set; }
        public string Agresja { get; set; }

        public Przeglad(DateTime? data_przegladu, int ile_ramek_miod, int ile_miodu, string jaki_miod, int korpusy, int ramki, int ramki_z_miodem, int ramki_z_czerwiem, int ramki_z_pierzgą, int ramki_z_węzą, bool matka, bool mateczniki, bool jajeczka, bool czerw_otwarty, bool czerw_zasklepiony, bool czerw_trutowy, bool nakrop, bool miód_zasklepiony, bool pierzga, string sila, string agresja)
        {
            this.data_przegladu = data_przegladu;
            Ile_ramek_miod = ile_ramek_miod;
            Ile_miodu = ile_miodu;
            Jaki_miod = jaki_miod;
            Korpusy = korpusy;
            Ramki = ramki;
            Ramki_z_miodem = ramki_z_miodem;
            Ramki_z_czerwiem = ramki_z_czerwiem;
            Ramki_z_pierzgą = ramki_z_pierzgą;
            Ramki_z_węzą = ramki_z_węzą;
            Matka = matka;
            Mateczniki = mateczniki;
            Jajeczka = jajeczka;
            Czerw_otwarty = czerw_otwarty;
            Czerw_zasklepiony = czerw_zasklepiony;
            Czerw_trutowy = czerw_trutowy;
            Nakrop = nakrop;
            Miód_zasklepiony = miód_zasklepiony;
            Pierzga = pierzga;
            Sila = sila;
            Agresja = agresja;
        }

        public string JsonSerialize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

