using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWars.Data
{
    public class PeopleDataModel
    {
        public string birth_year { get; set; }
        public string eye_color { get; set; }
        public List<string> films { get; set; }
        public string gender { get; set; }
        public string hair_color { get; set; }
        public string height { get; set; }
        public int Height => int.TryParse(height, out var value) ? value : 0;
        public string homeworld { get; set; }
        public string mass { get; set; }
        public int Mass => int.TryParse(mass, out var value) ? value : 0;
        public string name { get; set; }
        public string skin_color { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public List<string> species { get; set; }
        public List<string> starships { get; set; }
        public string url { get; set; }
        public List<string> vehicles { get; set; }
    }
}
