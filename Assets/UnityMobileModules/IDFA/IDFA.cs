using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityMobileModules
{
    /// <summary>
    /// Gets the Identifier For Advertisers (IDFA)
    /// </summary>
    public static partial class IDFA
    {
        /// <summary>
        /// Returns the IDFA of the device
        /// </summary>
        /// <returns></returns>
        public static string advertisingIdentifier
        {
            get
            {
#if UNITY_ANDROID
                return advertisingIdentifier_Android;
#elif UNITY_IOS
                return UnityEngine.iOS.Device.advertisingIdentifier;
#endif
            }
        }
    }
}
