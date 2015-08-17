﻿using Melia.Shared.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Channel.World
{
	public class Character : Shared.World.Character
	{
		public int WorldId { get; set; }

		public Character()
		{
			this.Level = 1;
			this.WorldId = 1337;
		}

		public float GetSpeed()
		{
			return 50;
		}

		public float GetJumpStrength()
		{
			return 300;
		}

		public int GetJumpType()
		{
			return 1;
		}
	}
}
