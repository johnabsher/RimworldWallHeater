using System;
using Verse;

namespace WallHeater
{
	public class CompProperties_OffsetGlower : CompProperties
	{
		public CompProperties_OffsetGlower()
		{
			this.compClass = typeof(CompGlowerOffset);
		}
		public string glowerDefName = "";
	}
}