using System;
using UnityEngine;

namespace UnityMobileModules
{
#if UNITY_ANDROID
    public static partial class Volume
    {
        /// <summary>
        /// Package Name
        /// </summary>
        const string javaPackageName = "com.UnityMobileModules";

        /// <summary>
        /// Class Name
        /// </summary>
        const string javaClassName = "Volume";

        /// <summary>
        /// Method Name to get the ringer level
        /// </summary>
        const string GetRingerVolume_MethodName = "GetRingerVolume";

        /// <summary>
        /// Method Name to get the max ringer level
        /// </summary>
        const string GetRingerMaxVolume_MethodName = "GetRingerMaxVolume";

        /// <summary>
        /// Method Name to get the music level
        /// </summary>
        const string GetMusicVolume_MethodName = "GetMusicVolume";

        /// <summary>
        /// Method Name to get the max music level
        /// </summary>
        const string GetMusicMaxVolume_MethodName = "GetMusicMaxVolume";

        /// <summary>
        /// Method Name to get the alarm level
        /// </summary>
        const string GetAlarmVolume_MethodName = "GetAlarmVolume";

        /// <summary>
        /// Method Name to get the max alarm level
        /// </summary>
        const string GetAlarmMaxVolume_MethodName = "GetAlarmMaxVolume";

        /// <summary>
        /// Java Class to interface with
        /// </summary>
        static readonly AndroidJavaClass javaClass;

        /// <summary>
        /// Static constructor, guaranteed to run when one of the properties are called
        /// </summary>
        static Volume()
        {
#if !UNITY_EDITOR
            javaClass = new AndroidJavaClass(javaPackageName + "." + javaClassName);
#endif
        }

        /// <summary>
        /// Gets the ringer volume
        /// </summary>
        static int RingerVolume_Android
        {
            get
            {
                return javaClass.CallStatic<int>(GetRingerVolume_MethodName);
            }
        }

        /// <summary>
        /// Gets the max ringer volume
        /// </summary>
        static int RingerMaxVolume_Android
        {
            get
            {
                return javaClass.CallStatic<int>(GetRingerMaxVolume_MethodName);
            }
        }

        /// <summary>
        /// Gets the music volume
        /// </summary>
        static int MusicVolume_Android
        {
            get
            {
                return javaClass.CallStatic<int>(GetMusicVolume_MethodName);
            }
        }

        /// <summary>
        /// Gets the max music volume
        /// </summary>
        static int MusicMaxVolume_Android
        {
            get
            {
                return javaClass.CallStatic<int>(GetMusicMaxVolume_MethodName);
            }
        }

        /// <summary>
        /// Gets the alarm volume
        /// </summary>
        static int AlarmVolume_Android
        {
            get 
            {
                return javaClass.CallStatic<int>(GetAlarmVolume_MethodName);
            }
        }

        /// <summary>
        /// Gets the max alarm volume
        /// </summary>
        static int AlarmMaxVolume_Android
        {
            get
            {
                return javaClass.CallStatic<int>(GetAlarmMaxVolume_MethodName);
            }
        }
    }
#endif
}
