using System;
using Verse;

namespace WallHeater
{
	// Token: 0x0200000C RID: 12
	public class CompProperties_OffsetGlower : CompProperties
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00003BB9 File Offset: 0x00001DB9
		public CompProperties_OffsetGlower()
		{
			this.compClass = typeof(CompGlowerOffset);
		}

		// Token: 0x04000037 RID: 55
		public string glowerDefName = "";
	}
}