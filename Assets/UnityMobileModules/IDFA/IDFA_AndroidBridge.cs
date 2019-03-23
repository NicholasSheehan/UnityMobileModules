using UnityEngine;

namespace UnityMobileModules
{
#if UNITY_ANDROID
    public static partial class IDFA
    {
        /// <summary>
        /// Package Name
        /// </summary>
        const string javaPackageName = "com.UnityMobileModules";

        /// <summary>
        /// Class Name
        /// </summary>
        const string javaClassName = "IDFA";

        /// <summary>
        /// Method Name to find all installed app display names
        /// </summary>
        const string GetIDFA_MethodName = "GetIDFA";

        /// <summary>
        /// Java Class to interface with
        /// </summary>
        static readonly AndroidJavaClass javaClass;

        /// <summary>
        /// Static constructor, guaranteed to run when one of the properties are called
        /// </summary>
        static IDFA()
        {
#if !UNITY_EDITOR
            javaClass = new AndroidJavaClass(javaPackageName + "." + javaClassName);
#endif
        }

        /// <summary>
        /// Gets the IDFA for Android
        /// </summary>
        static string advertisingIdentifier_Android
        {
            get
            {
                return javaClass.CallStatic<string>(GetIDFA_MethodName);
            }
        }
    }
#endif
}
