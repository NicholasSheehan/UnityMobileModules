using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityMobileModules
{
	/// <summary>
	/// Returns the internet state
	/// </summary>
    public static partial class Internet
    {
        /// <summary>
        /// Returns the internet state
        /// </summary>
        public static NetworkReachability internetState
        {
            get
            {
                return Application.internetReachability;
            }
        }

        /// <summary>
        /// Is the device connected to a mobile network
        /// </summary>
        public static bool connectedToMobileNetwork
        {
            get
            {
                return Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork;
            }
        }

        /// <summary>
        /// Is the device connected to WiFi or plugged in via Ethernet
        /// </summary>
        public static bool connectedToLan
        {
            get
            {
                return Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork;
            }
        }

        /// <summary>
        /// Can the device connect to the internet
        /// </summary>
        public static bool connectedToInternet
        {
            get
            {
                return Application.internetReachability != NetworkReachability.NotReachable;
            }
        }
    }
}
