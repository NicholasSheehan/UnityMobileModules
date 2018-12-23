using System;
using UnityEngine;

namespace UnityMobileModules
{
#if UNITY_ANDROID
    public static partial class Brightness
    {
        /// <summary>
        /// Package Name
        /// </summary>
        const string javaPackageName = "com.UnityMobileModules";

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
#if !UNITY_EDITOR
            javaClass = new AndroidJavaClass(javaPackageName + "." + javaClassName);
#endif
        }

        /// <summary>
        /// Gets and Sets the normalized brightness to native Android
        /// </summary>
        static float normalizedBrightness_Android
        {
            get
            {
                var brightness = javaClass.CallStatic<int>(getNormalizedBrightness_MethodName);
                float ret = brightness / 255f;
                //Debug.Log("Returned Normalized Brightness : " + ret);
                return ret;
            }
            set
            {
                var unroundedBrightness = value * 255f;
                var roundedBrightness = Mathf.RoundToInt(unroundedBrightness);
                //Debug.Log("Set Brightness : " + roundedBrightness);
                javaClass.CallStatic(setNormalizedBrightness_MethodName, roundedBrightness);
            }
        }
    }
#endif
}
