﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox.Common
{
    public class MyEngineConstants
    {
        //  Physics
        // This should be in VRage.Engine once it exists
        public const float UPDATE_STEPS_PER_SECOND = 60;       //  Looks like if I set it bellow 100 (e.g. to 60), mouse rotation seems not-seamless...
        public const float UPDATE_STEP_SIZE_IN_SECONDS = 1.0f / UPDATE_STEPS_PER_SECOND;
        public const int UPDATE_STEP_SIZE_IN_MILLISECONDS = (int)(1000.0f / UPDATE_STEPS_PER_SECOND);
    }
}
