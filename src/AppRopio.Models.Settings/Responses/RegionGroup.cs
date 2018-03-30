using System;
using System.Collections.Generic;

namespace AppRopio.Models.Settings.Responses
{
    public class RegionGroup
    {
        public string Title { get; set; }

        public List<Region> Regions { get; set; }
    }
}