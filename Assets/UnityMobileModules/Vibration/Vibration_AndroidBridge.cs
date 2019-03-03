using System;
using UnityEngine;

namespace UnityMobileModules
{
#if UNITY_ANDROID
    public static partial class Vibration
    {
        /// <summary>
        /// Package Name
        /// </summary>
        const string javaPackageName = "com.UnityMobileModules";

        /// <summary>
        /// Class Name
        /// </summary>
        const string javaClassName = "Vibration";

        /// <summary>
        /// Method Name to vibrate the device
        /// </summary>
        const string Vibrate_MethodName = "Vibrate";

        /// <summary>
        /// Method Name to vibrate a pattern on the device
        /// </summary>
        const string VibratePattern_MethodName = "VibratePattern";
        
        const long LIGHT_DURATION = 25L;
        const long MEDIUM_DURATION = 50L;
        const long HEAVY_DURATION = 100L;

        const int LIGHT_AMPLITUDE = 64;
        const int MEDIUM_AMPLITUDE = 128;
        const int HEAVY_AMPLITUDE = 255;

        static readonly long[] SUCCESS_PATTERN = { 0, LIGHT_DURATION, LIGHT_DURATION, HEAVY_DURATION };
        static readonly int[] SUCCESS_AMPLITUDE = { 0, LIGHT_AMPLITUDE, 0, HEAVY_AMPLITUDE };

        static readonly long[] WARNING_PATTERN = { 0, HEAVY_DURATION, LIGHT_DURATION, MEDIUM_DURATION };
        static readonly int[] WARNING_AMPLITUDE = { 0, HEAVY_AMPLITUDE, 0, MEDIUM_AMPLITUDE };

        static readonly long[] FAILURE_PATTERN = { 0, MEDIUM_DURATION, LIGHT_DURATION, MEDIUM_DURATION, LIGHT_DURATION, HEAVY_DURATION, LIGHT_DURATION, LIGHT_DURATION };
        static readonly int[] FAILURE_AMPLITUDE = { 0, MEDIUM_AMPLITUDE, 0, MEDIUM_AMPLITUDE, 0, HEAVY_AMPLITUDE, 0, LIGHT_AMPLITUDE };

        /// <summary>
        /// Java Class to interface with
        /// </summary>
        static readonly AndroidJavaClass javaClass;

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
        /// <param name="milliseconds">Milliseconds to vibrate for</param>
        /// <param name="amplitude">Amplitude to vibrate at</param>
        static void Vibrate_Android(long milliseconds, int amplitude)
        {
            javaClass.CallStatic(Vibrate_MethodName, milliseconds, amplitude);
        }

        /// <summary>
        /// Simple vibrate on Android
        /// </summary>
        /// <param name="pattern">Pattern to vibrate</param>
        /// <param name="amplitudes">Amplitudes of the pattern</param>
        /// <param name="repeat">Repeat mode, -1 = once</param>
        static void VibratePattern_Android(long[] pattern, int[] amplitudes, int repeat = -1)
        {
            javaClass.CallStatic(VibratePattern_MethodName, pattern, amplitudes, repeat);
        }
    }
#endif
}
