using UnityEngine;

namespace UnityMobileModules
{
    /// <summary>
    /// Battery based information
    /// </summary>
    public static partial class Battery
    {
        /// <summary>
        /// Is the device charging.
        /// </summary>
        public static bool isCharging
        {
            get
            {
                return SystemInfo.batteryStatus == BatteryStatus.Charging;
            }
        }

        /// <summary>
        /// Is the device plugged in.
        /// </summary>
        public static bool isPluggedIn
        {
            get
            {
                return SystemInfo.batteryStatus == BatteryStatus.Charging || SystemInfo.batteryStatus == BatteryStatus.NotCharging;
            }
        }

        /// <summary>
        /// Returns the battery status
        /// </summary>
        public static BatteryStatus batteryStatus
        {
            get
            {
                return SystemInfo.batteryStatus;
            }
        }
		
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
