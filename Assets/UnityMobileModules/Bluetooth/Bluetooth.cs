namespace UnityMobileModules
{
    public static partial class Bluetooth
    {
        /// <summary>
        /// Does the device support Bluetooth
        /// </summary>
        public static bool deviceSupportsBluetooth
        {
            get
            {
#if UNITY_EDITOR
                return false;
#elif UNITY_ANDROID
                return DeviceSupportsBluetooth_Android;
#elif UNITY_IOS

#endif
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool isEnabled
        {
            get
            {
                if (!deviceSupportsBluetooth) return false;
#if UNITY_EDITOR
                return false;
#elif UNITY_ANDROID
                return IsEnabled_Android;
#elif UNITY_IOS

#endif
            }
        }
    }
}
