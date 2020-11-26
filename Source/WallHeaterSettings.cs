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
        internal static float heaterPower;
        internal static float coolerPower;

        public override void ExposeData()
        {
            base.ExposeData();

            Scribe_Values.Look(ref heaterPower, "heaterPower");
            Scribe_Values.Look(ref coolerPower, "coolerPower");

            // Remove all null entries in the oreDictionary
            // This is most likely due to removing a mod, which will trigger a game reset
            if (Scribe.mode == LoadSaveMode.LoadingVars)
            {
                if (heaterPower == 0f)
                {
                    heaterPower = 21f;
                }
                if (coolerPower == 0f)
                {
                    coolerPower = -15f;
                }
            }
        }
    }
}
