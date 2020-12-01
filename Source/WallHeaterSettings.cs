using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using UnityEngine;

namespace WallHeater
{
    class WallHeaterSettings : ModSettings
    {
        public static float heaterPower = 21f;

        public override void ExposeData()
        {
            Scribe_Values.Look(ref heaterPower, "heaterPower", 21f);
            base.ExposeData();
        }
    }
}
