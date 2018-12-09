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
    }
}
