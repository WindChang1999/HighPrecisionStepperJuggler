﻿namespace HighPrecisionStepperJuggler
{
    // High Level machine state
    public struct HLMachineState
    {
        public float Height { get; }
        public float XTilt { get; }
        public float YTilt { get; }

        public HLMachineState(float height, float xTilt, float yTilt)
        {
            Height = height;
            XTilt = xTilt;
            YTilt = yTilt;
        }
    }
}
