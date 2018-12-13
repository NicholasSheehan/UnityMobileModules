using UnityEngine;

namespace UnityMobileModules
{
#if UNITY_ANDROID
    public static partial class Alert
    {
        /// <summary>
        /// Package Name
        /// </summary>
        const string javaPackageName = "com.UnityMobileModules";

        /// <summary>
        /// Class Name
        /// </summary>
        const string javaClassName = "Alert";

        /// <summary>
        /// Method Name to show an Alert
        /// </summary>
        const string ShowAlert_MethodName = "ShowAlert";
        /// <summary>
        /// Java Class to interface with
        /// </summary>
        static readonly AndroidJavaClass javaClass;

        /// <summary>
        /// Static constructor, guaranteed to run when one of the properties are called
        /// </summary>
        static Alert()
        {
#if UNITY_EDITOR
            return;
#endif
            javaClass = new AndroidJavaClass(javaPackageName + "." + javaClassName);
        }

        /// <summary>
        /// Shows an Alert
        /// </summary>
        /// <param name="alertTitle">Title of the alert</param>
        /// <param name="alertBody">Text of the alert</param>
        /// <param name="cancelButtonText">Text to display on the cancel button</param>
        static void ShowAlert_Android(string alertTitle, string alertBody, string cancelButtonText)
        {
            javaClass.CallStatic(ShowAlert_MethodName, alertTitle, alertBody, cancelButtonText);
        }
    }
#endif
}
