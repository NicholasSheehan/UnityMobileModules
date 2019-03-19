namespace UnityMobileModules
{
#if UNITY_IOS
    public static partial class Vibration
    {
#if UNITY_EDITOR
        static void iOS_Selection() { }
        static void iOS_Success() { }
        static void iOS_Warning() { }
        static void iOS_Failure() { }
        static void iOS_LightImpact() { }
        static void iOS_MediumImpact() { }
        static void iOS_HeavyImpact() { }
#else
        [System.Runtime.InteropServices.DllImport("__Internal")]
        static extern void iOS_Selection();

        [System.Runtime.InteropServices.DllImport("__Internal")]
        static extern void iOS_Success();

        [System.Runtime.InteropServices.DllImport("__Internal")]
        static extern void iOS_Warning();

        [System.Runtime.InteropServices.DllImport("__Internal")]
        static extern void iOS_Failure();

        [System.Runtime.InteropServices.DllImport("__Internal")]
        static extern void iOS_LightImpact();

        [System.Runtime.InteropServices.DllImport("__Internal")]
        static extern void iOS_MediumImpact();

        [System.Runtime.InteropServices.DllImport("__Internal")]
        static extern void iOS_HeavyImpact();
#endif
    }
#endif
}
