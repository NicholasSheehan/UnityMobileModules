namespace UnityMobileModules
{
	/// <summary>
    /// Shows an Alert
    /// </summary>
    public static partial class Alert
    {
        /// <summary>
        /// Shows an Alert
        /// </summary>
        /// <param name="alertTitle">Title of the alert</param>
        /// <param name="alertBody">Text of the alert</param>
        /// <param name="cancelButtonText">Text to display on the cancel button</param>
        public static void ShowAlert(string alertTitle, string alertBody, string cancelButtonText)
        {
#if UNITY_EDITOR
            return;
#elif UNITY_ANDROID
            ShowAlert_Android(alertTitle, alertBody, cancelButtonText);
#elif UNITY_IOS

#endif
        }
    }
}
