using UnityEngine;

namespace UnityMobileModules
{
    /// <summary>
    /// Brightness based information
    /// </summary>
    public static partial class Brightness
    {
        /// <summary>
        /// Gets and sets the normalized brightness of the device in a 0-1 range.
        /// </summary>
        public static float normalizedBrightness
        {
            get
            {
#if UNITY_EDITOR
                //Debug.LogWarning("Getting value normalizedBrightness, returning value of -1");
                return -1;
#elif UNITY_ANDROID
                return normalizedBrightness_Android;
#elif UNITY_IOS

#endif
            }
            set
            {
#if UNITY_EDITOR
                return;
#elif UNITY_ANDROID
                normalizedBrightness_Android = value;
#elif UNITY_IOS

#endif
            }
        }

        /// <summary>
        /// Gets and sets the brightness of the device in a 0-100 range.
        /// </summary>
        public static float brightness
        {
            get
            {
#if UNITY_EDITOR
                //Debug.LogWarning("Called brightness, returning value of -1");
                return -1;
#else
                return normalizedBrightness * 100f;
#endif
            }
            set
            {
#if UNITY_EDITOR
                return;
#else
                normalizedBrightness = value * 0.01f;
#endif
            }
        }
    }
}
