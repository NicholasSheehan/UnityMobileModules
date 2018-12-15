using UnityEngine;

namespace UnityMobileModules
{
    /// <summary>
    /// Checks if the contents of the game is the same as when it was built. 2017.1+
    /// <para>See https://docs.unity3d.com/ScriptReference/Application-genuine.html for more details</para>
    /// </summary>
    public static class AppValidity
    {
        /// <summary>
        /// App Validity States
        /// </summary>
        public enum AppValidityState
        {
            /// <summary>
            /// The check is not currently available
            /// </summary>
            CheckNotAvailable = -1,

            /// <summary>
            /// The contents of the build is the same as when it was built
            /// </summary>
            Genuine = 0,

            /// <summary>
            /// The contents of the build has been modified since it was built
            /// </summary>
            Modified = 1
        }

        /// <summary>
        /// The state of the contents of the build
        /// </summary>
        public static AppValidityState validityState
        {
            get
            {
#if !UNITY_2017_1_OR_NEWER
                return AppValidityState.CheckNotAvailable;
#endif
                if (!Application.genuineCheckAvailable) return AppValidityState.CheckNotAvailable;
                return Application.genuine ? AppValidityState.Genuine : AppValidityState.Modified;
            }
        }
    }
}
