﻿using System.Collections.Generic;

namespace Pipliz.Mods.BaseGame.GrowableBlocks
{
	using APIProvider.GrowableBlocks;

	public class Wheat : BaseGrowableBlockDefinition
	{
		public Wheat ()
		{
			GrowthType = EGrowthType.FirstNightRandom;
			SetStages(new List<GrowableStage>()
			{
				new GrowableStage("wheatstage1"),
				new GrowableStage("wheatstage2"),
				new GrowableStage("wheatstage3")
			});
		}
	}
}
