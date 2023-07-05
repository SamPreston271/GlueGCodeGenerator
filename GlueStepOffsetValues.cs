using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlueGCodeGenerator
{
    public class GlueStepOffsetValues
    {

    }

    public class GCode_Values
    {
        public const float Z        = MTG_StepOffsets.MTG_6mm_Z_Retract;
        public const int Feedrate   = MTG_StepOffsets.MTG_FeedDefault;
    }

    public class MTG_StepOffsets
    {
        public const float MTG_X_Offset        = 26.0f; // Distance to first MTG product in X direction
        public const float MTG_Y_Offset        = 1.1f;  // Distance to first MTG product in Y direction
        public const float MTG_X_Step          = 38.1f; // Distance between each MTG product in X direction
        public const float MTG_Y_Step          = 38.1f; // Distance between each MTG product in Y direction
        public const float MTG_Glue_Step       = 4.0f;  // Step value across area where magnet is glued
        public const int MTG_FeedDefault       = 10000; // Feed rate initialization
        public const int MTG_FeedRetract       = 2000;  // Feed rate while retracting device
        public const int MTG_FeedDispense      = 250;   // Feed rate while dispensing device

        public const float MTG_6mm_Z_TipOffset = 31.0f;  // ***Need to find this value***
        public const float MTG_6mm_Z_Dispense  = MTG_6mm_Z_TipOffset - 9.0f;  // ***Need to find this value***
        public const float MTG_6mm_Z_Retract   = MTG_6mm_Z_Dispense + 10.0f;  // ***Need to find this value***

        public const float MTG_3mm_Z_Dispense  = 0.0f;  // ***Need to find this value***
        public const float MTG_3mm_Z_Retract   = 0.0f;  // ***Need to find this value***
        public const float MTG_3mm_Z_TipOffset = 0.0f;  // ***Need to find this value***

    }
}
