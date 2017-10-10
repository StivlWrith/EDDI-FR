﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EddiDataDefinitions
{
    ///<summary>A launchbay is an internal slot within a ship housing SRV or fighter vehicles</summary>
    public class LaunchBay
    {
        // The name of the launchbay
        public string name { get; set; }
        /// <summary>The size of the launchbay</summary>
        public int size { get; set; }
        // The type of the launchbay ("SRV" or "Fighter")
        public string type { get; set; }
        /// <summary>The module residing in the launchbay (can be null)</summary>
        public List <Vehicle> vehicles { get; set; }
    }
}
