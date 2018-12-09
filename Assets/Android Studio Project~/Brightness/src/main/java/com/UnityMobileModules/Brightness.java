package com.UnityMobileModules;

import android.content.ContentResolver;
import android.provider.Settings;
import android.view.Window;
import android.view.WindowManager;

import com.unity3d.player.UnityPlayer;

public class Brightness {

    /**
     * Gets the normalized brightness value of the screen
     * @return float - How bright the screen is in a range of 0-1, where 0 is dark and 1 is bright
     */
    public static float GetNormalizedBrightness(){

        ContentResolver resolver = UnityPlayer.currentActivity.getContentResolver();

        float brightness;

        try {
            brightness = android.provider.Settings.System.getInt(resolver, android.provider.Settings.System.SCREEN_BRIGHTNESS);
        } catch (Settings.SettingNotFoundException e) {
            brightness = -1;
        }

        return brightness;
    }

    /**
     * Sets the brightness
     * @param brightness - Value between 0-1
     */
    public static void SetNormalizedBrightness(float brightness){
        Window window = UnityPlayer.currentActivity.getWindow();

        WindowManager.LayoutParams layoutParams = window.getAttributes();
        layoutParams.screenBrightness = brightness;
        window.setAttributes(layoutParams);
    }

}
