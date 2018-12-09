using UnityEngine;

namespace UnityMobileModules
{
    /// <summary>
    /// Brightness based information
    /// </summary>
    public static partial class Brightness
    {
        /// <summary>
        /// Package Name
        /// </summary>
        const string javaPackageName = "com.UnityMobileModule";

        /// <summary>
        /// Class Name
        /// </summary>
        const string javaClassName = "Brightness";

        /// <summary>
        /// Method Name to get brightness level
        /// </summary>
        const string getNormalizedBrightness_MethodName = "GetNormalizedBrightness";

        /// <summary>
        /// Method Name to set brightness level
        /// </summary>
        const string setNormalizedBrightness_MethodName = "SetNormalizedBrightness";

        /// <summary>
        /// Java Class to interface with
        /// </summary>
        static readonly AndroidJavaClass javaClass;

        /// <summary>
        /// Static constructor, guaranteed to run when one of the properties are called
        /// </summary>
        static Brightness()
        {
            javaClass = new AndroidJavaClass(javaPackageName + "." + javaClassName);
        }
        
        /// <summary>
        /// Gets and Sets the normalized brightness to native Android
        /// </summary>
        static float normalizedBrightness_Android
        {
            get
            {
                return javaClass.CallStatic<float>(getNormalizedBrightness_MethodName);
            }
            set
            {
                javaClass.CallStatic(setNormalizedBrightness_MethodName, value);
            }
        }
    }
}
