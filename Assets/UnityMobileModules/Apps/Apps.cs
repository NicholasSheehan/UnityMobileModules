namespace UnityMobileModules
{
    public static partial class Apps
    {
        /// <summary>
        /// Gets all installed app display names
        /// </summary>
        public static string[] installedAppDisplayNames
        {
            get
            {
#if UNITY_EDITOR
                return new string[0];
#elif UNITY_ANDROID
                return installedAppDisplayNames_Android;
#elif UNITY_IOS

#endif
            }
        }

        /// <summary>
        /// Gets all installed app package names
        /// </summary>
        public static string[] installedAppPackageNames
        {
            get
            {
#if UNITY_EDITOR
                return new string[0];
#elif UNITY_ANDROID
                return installedAppPackageNames_Android;
#elif UNITY_IOS

#endif
            }
        }
    }
}
