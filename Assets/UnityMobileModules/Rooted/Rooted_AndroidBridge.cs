using System;
using UnityEngine;

namespace UnityMobileModules
{
#if UNITY_ANDROID
    /// <summary>
    /// Brightness based information
    /// </summary>
    public static partial class Rooted
    {
        /// <summary>
        /// Package Name
        /// </summary>
        const string javaPackageName = "com.UnityMobileModules";

        /// <summary>
        /// Class Name
        /// </summary>
        const string javaClassName = "Rooted";

        /// <summary>
        /// Method Name to see if the device is rooted
        /// </summary>
        const string IsRooted_MethodName = "IsRooted";

        /// <summary>
        /// Java Class to interface with
        /// </summary>
        static readonly AndroidJavaClass javaClass;

        /// <summary>
        /// Static constructor, guaranteed to run when one of the properties are called
        /// </summary>
        static Rooted()
        {
#if !UNITY_EDITOR
            javaClass = new AndroidJavaClass(javaPackageName + "." + javaClassName);
#endif
        }

        /// <summary>
        /// Checks to see if the device is rooted
        /// </summary>
        static bool IsRooted_Android
        {
            get
            {
                return javaClass.CallStatic<bool>(IsRooted_MethodName);
            }
        }
    }
#endif
}
