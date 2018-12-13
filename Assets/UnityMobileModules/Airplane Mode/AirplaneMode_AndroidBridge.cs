using UnityEngine;

namespace UnityMobileModules
{
#if UNITY_ANDROID
    public static partial class AirplaneMode
    {
        /// <summary>
        /// Package Name
        /// </summary>
        const string javaPackageName = "com.UnityMobileModules";

        /// <summary>
        /// Class Name
        /// </summary>
        const string javaClassName = "AirplaneMode";

        /// <summary>
        /// Method Name to find if Airplane Mode is on
        /// </summary>
        const string IsAirplaneModeOn_MethodName = "IsAirplaneModeOn";

        /// <summary>
        /// Java Class to interface with
        /// </summary>
        static readonly AndroidJavaClass javaClass;

        /// <summary>
        /// Static constructor, guaranteed to run when one of the properties are called
        /// </summary>
        static AirplaneMode()
        {
#if !UNITY_EDITOR
            javaClass = new AndroidJavaClass(javaPackageName + "." + javaClassName);
#endif
        }

        /// <summary>
        /// Is Airplane Mode On
        /// </summary>
        static bool IsAirplaneModeOn_Android
        {
            get
            {
                return javaClass.CallStatic<bool>(IsAirplaneModeOn_MethodName);
            }
        }
    }
#endif
}
