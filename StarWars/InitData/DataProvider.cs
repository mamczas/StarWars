using Newtonsoft.Json;
using StarWars.Context.Models;
using System.Collections.Generic;
using System.IO;

namespace StarWars.Data
{
    public static class DataProvider
    {

        public static IEnumerable<StarsShip> GetStarsStips()
        {

            var json = File.ReadAllText("Data/StarsShips.json");
            var data = JsonConvert.DeserializeObject<List<StarsShipDataModel>>(json);
            var result = new List<StarsShip>();
            for (int i = 0; i < data.Count; i++)
            {
                result.Add(new StarsShip {
                    Id = i + 1,
                    CargoCapacity = data[i].CargoCapacity,
                    Consumables = data[i].Consumables,
                    CostInCredits = data[i].CostInCredits,
                    Created = data[i].Created,
                    Crew = data[i].Crew,
                    Edited = data[i].Edited,
                    HyperdriveRating = data[i].Hyperdrive_rating,
                    Length = data[i].Length,
                    Manufacturer = data[i].Manufacturer,
                    Max_atmosphering_speed = data[i].Max_atmosphering_speed,
                    Model = data[i].Model,
                    Name = data[i].Name,
                    Passengers = data[i].Passengersength,
                    Starship_class = data[i].Starship_class,
                });
            }

            return result;
        }

        public static IEnumerable<People> GetPeople()
        {

            var json = File.ReadAllText("Data/People.json");
            var data = JsonConvert.DeserializeObject<List<PeopleDataModel>>(json);
            var result = new List<People>();
            for (int i = 0; i < data.Count; i++)
            {
                result.Add(new People
                {
                    Id = i + 1,
                    Edited = data[i].edited,
                    Name = data[i].name,
                    BirthYear = data[i].birth_year,
                    Created = data[i].created,
                    EyeColor = data[i].eye_color,
                    Gender = data[i].gender,
                    HairColor = data[i].hair_color,
                    Height = data[i].Height,
                    Homeworld = data[i].homeworld,
                    Mass = data[i].Mass,
                    SkinColor = data[i].skin_color,
                    Url = data[i].url
                });
            }

            return result;
        }
    }
}
