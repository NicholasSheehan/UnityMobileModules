namespace UnityMobileModules
{
    /// <summary>
    /// Displays a Toast
    /// </summary>
    public static partial class Toast
    {
        /// <summary>
        /// Length off time to show the toast
        /// </summary>
        public enum ToastLength
        {
            /// <summary>
            /// Shows the toast for a short amount of time
            /// </summary>
            Short,

            /// <summary>
            /// Shows the toast for a long amount of time
            /// </summary>
            Long
        }

        /// <summary>
        /// Shows a toast
        /// </summary>
        /// <param name="toastText">Text to show on the toast</param>
        /// <param name="toastLength">Length of the toast</param>
        public static void ShowToast(string toastText, ToastLength toastLength)
        {
#if UNITY_EDITOR
            return;
#elif UNITY_ANDROID
            ShowToast_Android(toastText, toastLength == ToastLength.Long);
#elif UNITY_IOS

#endif
        }

        /// <summary>
        /// Shows a toast
        /// </summary>
        /// <param name="toastText">Text to show on the toast</param>
        /// <param name="longToast">Should a long toast be shown</param>
        public static void ShowToast(string toastText, bool longToast)
        {
#if UNITY_EDITOR
            return;
#elif UNITY_ANDROID
            ShowToast_Android(toastText, longToast);
#elif UNITY_IOS

#endif
        }
    }
}
