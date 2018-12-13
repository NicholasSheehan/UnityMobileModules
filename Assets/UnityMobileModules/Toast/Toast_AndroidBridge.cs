using System;
using UnityEngine;

namespace UnityMobileModules
{
#if UNITY_ANDROID
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
#if !UNITY_EDITOR
            javaClass = new AndroidJavaClass(javaPackageName + "." + javaClassName);
#endif
        }

        /// <summary>
        /// Shows a Toast
        /// </summary>
        /// <param name="toastText">Text to toast</param>
        /// <param name="longToast">Should a long toast be shown</param>
        static void ShowToast_Android(string toastText, bool longToast)
        {
            javaClass.CallStatic(ShowToast_MethodName, toastText, longToast);
        }
    }
#endif
}
