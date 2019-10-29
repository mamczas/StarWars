using System;

namespace StarWars.Context.Models
{
    public class StarsShip : IDataEntity
    {
        public int Id { get; set; }
        public long CargoCapacity { get; set; }
        public string Consumables { get; set; }
        public long CostInCredits { get; set; }
        public DateTime Created { get; set; }
        public long Crew { get; set; }
        public DateTime Edited { get; set; }
        public double HyperdriveRating { get; set; }
        public long Length { get; set; }
        public string Manufacturer { get; set; }
        public int Max_atmosphering_speed { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public int Passengers { get; set; }
        public string Starship_class { get; set; }
    }
}
