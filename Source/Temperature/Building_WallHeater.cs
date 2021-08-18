using WallHeater;
using RimWorld;
using Verse;
using UnityEngine;


namespace WallHeater
{
    public class Building_WallHeater : Building_Heater
    {
//        public Thing glower;

        private IntVec3 vecNorth;
        private IntVec3 dx;
        private Room roomNorth;
//        private CompMyGlower compGlower;
//        private bool isWorking;
//        private bool wasLit;

/*        private bool WorkingState
        {
            get { return isWorking; }
            set
            {
                isWorking = value;

                if (compPowerTrader == null || compTempControl == null)
                {
                    return;
                }
                if (isWorking)
                {
                    compPowerTrader.PowerOutput = -compPowerTrader.Props.basePowerConsumption;
                }
                else
                {
                    compPowerTrader.PowerOutput = -compPowerTrader.Props.basePowerConsumption*
                                                  compTempControl.Props.lowPowerConsumptionFactor;
                }

                compTempControl.operatingAtHighPower = isWorking;
            }
        }*/

        public override void SpawnSetup(Map map, bool respawningAfterLoad)
        {
            base.SpawnSetup(map, respawningAfterLoad);
            dx = IntVec3.North.RotatedBy( Rotation );
            vecNorth = Position + dx;
            Log.Message("Spawned - room loc:");
            Log.Message(vecNorth.ToStringSafe());

            //glower = GenSpawn.Spawn( ThingDef.Named( "Buildings_MediumHeater" ), vecNorth, map);
            //((Building_HeaterGlower) glower).Reinit( this );
            //compGlower = glower.TryGetComp< CompMyGlower >();
            //compGlower.UpdateLit(map, false);
        }
        public override void TickRare()
        {
            Log.Message("overriding base position");
            base.Position += dx;
            base.TickRare();
            Log.Message("resetting base position");
            base.Position -= dx;
        }

        protected virtual bool Validate()
        {
            Log.Message("Validated Placement");
            if (vecNorth.Impassable(this.Map))
            {
                return false;
            }

            roomNorth = vecNorth.GetRoom(this.Map);
            if (roomNorth == null)
            {
                return false;
            }

            return (compPowerTrader == null || compPowerTrader.PowerOn);
        }
    }
}
