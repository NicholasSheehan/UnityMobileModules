namespace UnityMobileModules
{
    public static partial class Volume
    {
        /// <summary>
        /// Checks the ringer volume
        /// </summary>
        public static int ringerVolume
        {
            get
            {
#if UNITY_EDITOR
                return 0;
#elif UNITY_ANDROID
                return RingerVolume_Android;
#elif UNITY_IOS

#endif
            }
        }

        /// <summary>
        /// Checks the max ringer volume
        /// </summary>
        public static int maxRingerVolume
        {
            get
            {
#if UNITY_EDITOR
                return 0;
#elif UNITY_ANDROID
                return RingerMaxVolume_Android;
#elif UNITY_IOS

#endif
            }
        }

        /// <summary>
        /// The normalized ringer volume
        /// </summary>
        public static float ringerNormalizedPercent
        {
            get { return (float)ringerVolume / maxRingerVolume; }
        }

        /// <summary>
        /// Checks the music volume
        /// </summary>
        public static int musicVolume
        {
            get
            {
#if UNITY_EDITOR
                return 0;
#elif UNITY_ANDROID
                return MusicVolume_Android;
#elif UNITY_IOS

#endif
            }
        }

        /// <summary>
        /// Checks the max music volume
        /// </summary>
        public static int maxMusicVolume
        {
            get
            {
#if UNITY_EDITOR
                return 0;
#elif UNITY_ANDROID
                return MusicMaxVolume_Android;
#elif UNITY_IOS

#endif
            }
        }

        /// <summary>
        /// The normalized music volume
        /// </summary>
        public static float musicNormalizedPercent
        {
            get { return (float)musicVolume / maxMusicVolume; }
        }

        /// <summary>
        /// Checks the alarm volume
        /// </summary>
        public static int alarmVolume
        {
            get
            {
#if UNITY_EDITOR
                return 0;
#elif UNITY_ANDROID
                return AlarmVolume_Android;
#elif UNITY_IOS

#endif
            }
        }

        /// <summary>
        /// Checks the alarm volume
        /// </summary>
        public static int maxAlarmVolume
        {
            get
            {
#if UNITY_EDITOR
                return 0;
#elif UNITY_ANDROID
                return AlarmMaxVolume_Android;
#elif UNITY_IOS

#endif
            }
        }

        /// <summary>
        /// The normalized alarm volume
        /// </summary>
        public static float alarmNormalizedPercent
        {
            get { return (float)alarmVolume / maxAlarmVolume; }
        }
    }
}
