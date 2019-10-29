﻿using System.Collections.Generic;

namespace StarWars.Services.Dto
{
    public class PageDto<T>
    {
        public List<T> PageCollection { get; set; }
        public int MaxPage { get; set; }
    }
}
