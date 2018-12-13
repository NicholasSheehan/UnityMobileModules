package com.UnityMobileModules;

import android.annotation.TargetApi;
import android.os.Build;
import android.provider.Settings;

import com.unity3d.player.UnityPlayer;

public class AirplaneMode
{
    /**
     * Gets the state of Airplane Mode
     * @return boolean
     **/
    @TargetApi(Build.VERSION_CODES.JELLY_BEAN_MR1)
    @SuppressWarnings({ "deprecation" })
    public static boolean IsAirplaneModeOn() {

        if (android.os.Build.VERSION.SDK_INT >= android.os.Build.VERSION_CODES.JELLY_BEAN_MR1){
            /* API 17 and above */
            return Settings.Global.getInt(UnityPlayer.currentActivity.getContentResolver(), Settings.Global.AIRPLANE_MODE_ON, 0) != 0;
        } else {
            /* below */
            return Settings.System.getInt(UnityPlayer.currentActivity.getContentResolver(), Settings.System.AIRPLANE_MODE_ON, 0) != 0;
        }
    }
}
