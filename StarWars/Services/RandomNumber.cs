using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWars.Services
{
    public static class RandomNumber
    {
        public static int GetFromRange(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
