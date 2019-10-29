using System;

namespace StarWars.Context.Models
{
    public class People: IDataEntity
    {
        public int Id { get; set; }
        public string BirthYear { get; set; }
        public string EyeColor { get; set; }
        public string Gender { get; set; }
        public string HairColor { get; set; }
        public int Height { get; set; }
        public string Homeworld { get; set; }
        public int Mass { get; set; }
        public string Name { get; set; }
        public string SkinColor { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }
}
