using System;

namespace UnityMobileModules
{
    /// <summary>
    /// Vibrates the device, based on iOS haptics
    /// <para>https://developer.apple.com/design/human-interface-guidelines/ios/user-interaction/feedback</para>
    /// </summary>
    public static partial class Vibration
    {
        /// <summary>
        /// Vibrates the device
        /// </summary>
        /// <param name="vibrationType">Type of vibration to start</param>
        public static void Vibrate(VibrationType vibrationType)
        {
            if (vibrationType == VibrationType.Selection)
            {
#if UNITY_ANDROID
                Vibrate_Android(LIGHT_DURATION, LIGHT_AMPLITUDE);
#elif UNITY_IOS
#endif
            }
            else if (vibrationType == VibrationType.SuccessNotification)
            {
#if UNITY_ANDROID
                VibratePattern_Android(SUCCESS_PATTERN, SUCCESS_AMPLITUDE);
#elif UNITY_IOS
#endif
            }
            else if (vibrationType == VibrationType.WarningNotification)
            {
#if UNITY_ANDROID
                VibratePattern_Android(WARNING_PATTERN, WARNING_AMPLITUDE);
#elif UNITY_IOS
#endif
            }
            else if (vibrationType == VibrationType.FailureNotification)
            {
#if UNITY_ANDROID
                VibratePattern_Android(FAILURE_PATTERN, FAILURE_AMPLITUDE);
#elif UNITY_IOS
#endif
            }
            else if (vibrationType == VibrationType.LightImpact)
            {
#if UNITY_ANDROID
                Vibrate_Android(LIGHT_DURATION, LIGHT_AMPLITUDE);
#elif UNITY_IOS
#endif
            }
            else if (vibrationType == VibrationType.MediumImpact)
            {
#if UNITY_ANDROID
                Vibrate_Android(MEDIUM_DURATION, MEDIUM_AMPLITUDE);
#elif UNITY_IOS
#endif
            }
            else if (vibrationType == VibrationType.HeavyImpact)
            {
#if UNITY_ANDROID
                Vibrate_Android(HEAVY_DURATION, HEAVY_AMPLITUDE);
#elif UNITY_IOS
#endif
            }
        }
    }

    /// <summary>
    /// Different types of vibrations
    /// </summary>
    public enum VibrationType
    {
        /// <summary>
        /// Light
        /// </summary>
        Selection = 0,

        /// <summary>
        /// Light -> Heavy
        /// </summary>
        SuccessNotification = 1,

        /// <summary>
        /// Heavy -> Medium
        /// </summary>
        WarningNotification = 2,

        /// <summary>
        /// Medium -> Medium -> Heavy -> Light
        /// </summary>
        FailureNotification = 3,

        /// <summary>
        /// Light
        /// </summary>
        LightImpact = 4,

        /// <summary>
        /// Medium
        /// </summary>
        MediumImpact = 5,

        /// <summary>
        /// Heavy
        /// </summary>
        HeavyImpact = 6,
    }
}
