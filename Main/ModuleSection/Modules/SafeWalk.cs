﻿using Ace_client.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ace_client.Main.ModuleSection.Modules
{
    public class SafeWalk : Module
    {
        public SafeWalk() : base("Movement")
        {

        }

        public override void onEnable()
        {
            base.onEnable();
            Statics.Fasts.FallSaverOn();
        }

        public override void onDisable()
        {
            base.onDisable();
            Statics.Fasts.FallSaverOff();
        }
    }
}
