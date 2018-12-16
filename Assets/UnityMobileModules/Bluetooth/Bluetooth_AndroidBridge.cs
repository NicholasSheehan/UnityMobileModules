using UnityEngine;

namespace UnityMobileModules
{
#if UNITY_ANDROID
    public static partial class Bluetooth
    {
        /// <summary>
        /// Package Name
        /// </summary>
        const string javaPackageName = "com.UnityMobileModules";

        /// <summary>
        /// Class Name
        /// </summary>
        const string javaClassName = "Bluetooth";

        /// <summary>
        /// Method Name to see if Bluetooth is supported
        /// </summary>
        const string DeviceSupportsHasBluetooth_MethodName = "DeviceSupportsBluetooth";

        /// <summary>
        /// Method Name to see if Bluetooth is enabled
        /// </summary>
        const string IsEnabled_MethodName = "IsEnabled";

        /// <summary>
        /// Method Name to get the ConnectedBluetoothDeviceType
        /// </summary>
        const string ConnectedBluetoothDeviceType_MethodName = "GetConnectedBluetoothDeviceType";

        /// <summary>
        /// Method Name to get the ConnectedBluetoothDeviceStatus
        /// </summary>
        const string ConnectedBluetoothDeviceStatus_MethodName = "GetConnectedBluetoothDeviceStatus";

        /// <summary>
        /// Method Name to get the Connected Bluetooth Device name
        /// </summary>
        const string ConnectedDeviceName_MethodName = "GetConnectedDeviceName";

        /// <summary>
        /// Java Class to interface with
        /// </summary>
        static readonly AndroidJavaClass javaClass;

        /// <summary>
        /// Static constructor, guaranteed to run when one of the properties are called
        /// </summary>
        static Bluetooth()
        {
#if !UNITY_EDITOR
            javaClass = new AndroidJavaClass(javaPackageName + "." + javaClassName);
#endif
        }

        /// <summary>
        /// 
        /// </summary>
        static bool DeviceSupportsBluetooth_Android
        {
            get
            {
                return javaClass.CallStatic<bool>(DeviceSupportsHasBluetooth_MethodName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        static bool IsEnabled_Android
        {
            get
            {
                return javaClass.CallStatic<bool>(IsEnabled_MethodName);
            }
        }
    }
#endif
}
