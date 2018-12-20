namespace UnityMobileModules
{
    public static partial class Rooted
    {
        /// <summary>
        /// Checks to see if the device is rooted
        /// </summary>
        public static bool isRooted
        {
            get
            {
#if UNITY_EDITOR
                return false;
#elif UNITY_ANDROID
                return IsRooted_Android;
#elif UNITY_IOS

#endif
            }
        }
    }
}
