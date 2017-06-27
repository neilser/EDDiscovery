﻿/*
 * Copyright © 2016 EDDiscovery development team
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this
 * file except in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software distributed under
 * the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF
 * ANY KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 *
 * EDDiscovery is not affiliated with Frontier Developments plc.
 */
using Newtonsoft.Json.Linq;
using System.Linq;

namespace EDDiscovery.EliteDangerous.JournalEvents
{
    /*When written: when the player is invited to a wing
Parameters:
•	Name: the commander name of the player inviting to the wing
*/
    //{   "timestamp": "2017-06-27T14:35:43Z",   "event": "WingInvite",   "Name": "<cmdr name>" }

[JournalEntryType(JournalTypeEnum.WingInvite)]
    public class JournalWingInvite : JournalEntry
    {
        public JournalWingInvite(JObject evt ) : base(evt, JournalTypeEnum.WingInvite)
        {
            Name = evt["Name"].Str();
        }

        public string Name { get; set; }

        public override System.Drawing.Bitmap Icon { get { return EDDiscovery.Properties.Resources.wingadd; } }

        public override void FillInformation(out string summary, out string info, out string detailed) //V
        {
            summary = EventTypeStr.SplitCapsWord();
            info = Name;
            detailed = "";
        }
    }
}