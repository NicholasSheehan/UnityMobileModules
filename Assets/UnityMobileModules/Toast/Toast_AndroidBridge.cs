using System;
using UnityEngine;

namespace UnityMobileModules
{
#if UNITY_ANDROID
    /// <summary>
    /// Brightness based information
    /// </summary>
    public static partial class Toast
    {
        /// <summary>
        /// Package Name
        /// </summary>
        const string javaPackageName = "com.UnityMobileModules";

        /// <summary>
        /// Class Name
        /// </summary>
        const string javaClassName = "Toast";

        /// <summary>
        /// Method Name to get brightness level
        /// </summary>
        const string ShowToast_MethodName = "ShowToast";

        /// <summary>
        /// Java Class to interface with
        /// </summary>
        static readonly AndroidJavaClass javaClass;

        /// <summary>
        /// Static constructor, guaranteed to run when one of the properties are called
        /// </summary>
        static Toast()
        {
#if UNITY_EDITOR
            return;
#endif
            javaClass = new AndroidJavaClass(javaPackageName + "." + javaClassName);
        }
        
        /// <summary>
        /// Shows toast
        /// </summary>
        static void ShowToast_Android(string toastText, ToastLength toastLength)
        {
            javaClass.Call(ShowToast_MethodName, toastText, toastLength == ToastLength.Long);
        }
    }
#endif
}
