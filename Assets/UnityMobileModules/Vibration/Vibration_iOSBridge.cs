using System;
using UnityEngine;

namespace UnityMobileModules
{
#if UNITY_IOS
    public static partial class Vibration
    {
        /// <summary>
        /// Static constructor, guaranteed to run when one of the properties are called
        /// </summary>
        static Vibration()
        {
#if !UNITY_EDITOR
            javaClass = new AndroidJavaClass(javaPackageName + "." + javaClassName);
#endif
        }

        /// <summary>
        /// Simple vibrate on Android
        /// </summary>
        static void Vibrate_iOS()
        {
        }
    }
#endif
}
