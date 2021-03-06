﻿namespace UnityMobileModules
{
	/// <summary>
    /// Airplane Mode information
    /// </summary>
    public static partial class AirplaneMode
    {
        /// <summary>
        /// Is Airplane Mode On?
        /// </summary>
        public static bool isAirplaneModeOn
        {
            get
            {
#if UNITY_EDITOR
                return false;
#elif UNITY_ANDROID
                return IsAirplaneModeOn_Android;
#elif UNITY_IOS

#endif
            }
        }

    }
}
