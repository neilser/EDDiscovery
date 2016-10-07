﻿using Newtonsoft.Json.Linq;
using System.Linq;

namespace EDDiscovery.EliteDangerous.JournalEvents
{
    //When written: when receiving salary payment from a power
    //Parameters:
    //•	Power
    //•	Amount
    public class JournalPowerplaySalary : JournalEntry
    {
        public JournalPowerplaySalary(JObject evt) : base(evt, JournalTypeEnum.PowerplaySalary)
        {
            Power = Tools.GetStringDef(evt["Power"]);
            Amount = Tools.GetInt(evt["Amount"]);
        }
        public string Power { get; set; }
        public int Amount { get; set; }

        public static System.Drawing.Bitmap Icon { get { return EDDiscovery.Properties.Resources.powerplaysalary; } }
    }
}
