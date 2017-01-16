using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biuro_Podrozy
{
    class Podroz : IData, IZarzadzaj
    {
        private DateTime dataPodrozy;
        private List<SrodekLokomocji> planPodrozy = new List<SrodekLokomocji>();
        private double koszt = 200;

        public void DodajExpress(int iloscMiejsc){
            planPodrozy.Add(new Express());
            koszt += planPodrozy[planPodrozy.Count].Cena();
        }

        public void DodajSamolot(int iloscMiejsc, int odleglosc) {
            planPodrozy.Add(new Samolot());
            koszt += planPodrozy[planPodrozy.Count].Cena();
        }

        public void UsunOstatni() {
            planPodrozy.RemoveAt(planPodrozy.Count - 1);
            koszt -= planPodrozy[planPodrozy.Count - 1].Cena();
        }
        public void Wyczysc() {
            planPodrozy.Clear();
            koszt = 200;
        }

        public bool SprawdzDate(bool data) {
            if(dataPodrozy > DateTime.Now)return true;
            else return false;
        }

        public override string ToString() {
            string Podroz = "";
            foreach (Object obj in planPodrozy) {
                Podroz += obj.ToString() + "\n";
            }
            if (Podroz == "")
                return "Brak elementow w planie podrozy";
            return Podroz;
        }
    }
}
