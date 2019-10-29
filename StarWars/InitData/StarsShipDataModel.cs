using System;

namespace StarWars.Data
{
    public class StarsShipDataModel
    {
        public string cargo_capacity { get; set; }
        public long CargoCapacity => long.TryParse(cargo_capacity, out var value) ? value: 0;
        public string Consumables { get; set; }
        public string cost_in_credits { get; set; }
        public long CostInCredits => long.TryParse(cost_in_credits, out var value) ? value : 0;
        public DateTime Created { get; set; }
        public string crew { get; set; }
        public long Crew => long.TryParse(crew, out var value) ? value : 0;
        public DateTime Edited { get; set; }
        public string hyperdrive_rating { get; set; }
        public double Hyperdrive_rating => double.TryParse(hyperdrive_rating, out var value) ? value : 0;
        public string length { get; set; }
        public long Length => long.TryParse(length, out var value) ? value : 0;
        public string Manufacturer { get; set; }
        public string max_atmosphering_speed { get; set; }
        public int Max_atmosphering_speed => int.TryParse(max_atmosphering_speed, out var value) ? value : 0;
        public string Model { get; set; }
        public string Name { get; set; }
        public string passengers { get; set; }
        public int Passengersength => int.TryParse(passengers, out var value) ? value : 0;
        public string Starship_class { get; set; }
    }
}
