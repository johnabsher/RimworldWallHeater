using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using UnityEngine;

namespace WallHeater
{
    class WallHeaterMod : Mod
    {
        private Vector2 scrollPosition = Vector2.zero;

        public WallHeaterMod(ModContentPack content) : base(content)
        {
            LongEventHandler.ExecuteWhenFinished(GetSettings);
        }

        public void GetSettings()
        {
            GetSettings<WallHeaterSettings>();
        }


        public override void DoSettingsWindowContents(Rect rect)
        {
            Listing_Standard list = new Listing_Standard()
            {
                ColumnWidth = rect.width
            };

            list.Begin(rect);

            list.Label("Wall Heater Heating Power: " + WallHeaterSettings.heaterPower);
            WallHeaterSettings.heaterPower = list.Slider(WallHeaterSettings.heaterPower, 0, 100);

            list.End();
        }

        public override string SettingsCategory()
        {
            return "Wall Heater";
        }
    }
}
