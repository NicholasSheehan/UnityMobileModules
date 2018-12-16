using UnityEngine;

namespace UnityMobileModules
{
#if UNITY_ANDROID
    public static partial class Apps
    {
        /// <summary>
        /// Package Name
        /// </summary>
        const string javaPackageName = "com.UnityMobileModules";

        /// <summary>
        /// Class Name
        /// </summary>
        const string javaClassName = "Apps";

        /// <summary>
        /// Method Name to find all installed app display names
        /// </summary>
        const string GetInstalledAppDisplayNames_MethodName = "GetInstalledAppDisplayNames";

        /// <summary>
        /// Method Name to find all installed app package names
        /// </summary>
        const string GetInstalledAppPackageNames_MethodName = "GetInstalledAppPackageNames";

        /// <summary>
        /// Java Class to interface with
        /// </summary>
        static readonly AndroidJavaClass javaClass;

        /// <summary>
        /// Static constructor, guaranteed to run when one of the properties are called
        /// </summary>
        static Apps()
        {
#if !UNITY_EDITOR
            javaClass = new AndroidJavaClass(javaPackageName + "." + javaClassName);
#endif
        }

        /// <summary>
        /// Gets all installed app display names
        /// </summary>
        static string[] installedAppDisplayNames_Android
        {
            get
            {
                return javaClass.CallStatic<string[]>(GetInstalledAppDisplayNames_MethodName);
            }
        }

        /// <summary>
        /// Gets all installed app package names
        /// </summary>
        static string[] installedAppPackageNames_Android
        {
            get
            {
                return javaClass.CallStatic<string[]>(GetInstalledAppPackageNames_MethodName);
            }
        }
    }
#endif
}
