using System;

namespace StarWars.Context
{
    public interface IDataEntity
    {
        DateTime Edited { get; set;}
        DateTime Created { get; set; }
    }
}
