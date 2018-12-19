using System;
using UnityEngine;

namespace UnityMobileModules
{
#if UNITY_ANDROID
    /// <summary>
    /// Brightness based information
    /// </summary>
    public static partial class DeepLinking
    {
        /// <summary>
        /// Package Name
        /// </summary>
        const string javaPackageName = "com.UnityMobileModules";

        /// <summary>
        /// Class Name
        /// </summary>
        const string javaClassName = "DeepLinking";

        /// <summary>
        /// Method Name to get the deep link uri
        /// </summary>
        const string GetDeepLinkURI_MethodName = "GetDeepLinkURI";

        /// <summary>
        /// Java Class to interface with
        /// </summary>
        static readonly AndroidJavaClass javaClass;

        /// <summary>
        /// Static constructor, guaranteed to run when one of the properties are called
        /// </summary>
        static DeepLinking()
        {
#if !UNITY_EDITOR
            javaClass = new AndroidJavaClass(javaPackageName + "." + javaClassName);
#endif
        }

        /// <summary>
        /// Gets the URL the app was open with, contains information for deep linking
        /// </summary>
        static string GetDeepLinkURI_Android
        {
            get
            {
                return javaClass.CallStatic<string>(GetDeepLinkURI_MethodName);
            }
        }
    }
#endif
}
