using UnityEngine;

namespace UnityMobileModules
{
    /// <summary>
    /// Battery based information
    /// </summary>
    public static partial class Battery
    {
        /// <summary>
        /// Battery percentage in the 0-1 range.
        /// <para>Returns -1 if device is not supported.</para>
        /// </summary>
        public static float normalizedBatteryPercentage
        {
            get
            {
                return SystemInfo.batteryLevel;
            }
        }

        /// <summary>
        /// Battery percentage in the 0-100 range.
        /// <para>Returns -1 if device is not supported.</para>
        /// </summary>
        public static float batteryPercentage
        {
            get
            {
                return SystemInfo.batteryLevel * 100f;
            }
        }
    }
}
