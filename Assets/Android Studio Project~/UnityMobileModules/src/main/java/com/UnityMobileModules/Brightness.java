package com.UnityMobileModules;

import android.content.ContentResolver;
import android.provider.Settings;

import com.unity3d.player.UnityPlayer;

public class Brightness {

    /**
     * Gets the normalized brightness value of the screen
     * @return float - How bright the screen is in a range of 0-255, where 0 is dark and 255 is bright
     */
    public static int GetNormalizedBrightness(){

        ContentResolver resolver = UnityPlayer.currentActivity.getContentResolver();

        int brightness;

        try {
            brightness = android.provider.Settings.System.getInt(resolver, android.provider.Settings.System.SCREEN_BRIGHTNESS);
        } catch (Settings.SettingNotFoundException e) {
            return -1;
        }

        return brightness;
    }

    ///**
    // * Sets the brightness
    // * @param brightness - Value between 0-255
    // */
    //public static void SetNormalizedBrightness(final int brightness){
    //    //https://stackoverflow.com/questions/26058090/how-to-set-screen-brightness-inside-android-application-locally
    //
    //    //This sets the system brightness
    //    //Requires permission <uses-permission android:name="android.permission.WRITE_SETTINGS" />
    //    ContentResolver contextResolver = UnityPlayer.currentActivity.getContentResolver();
    //    Settings.System.putInt(contextResolver, Settings.System.SCREEN_BRIGHTNESS, brightness);
    //
    //    //This sets the brightness of the app, and not the system
    //    //UnityPlayer.currentActivity.runOnUiThread(new Runnable() {
    //    //
    //    //    @Override
    //    //    public void run() {
    //    //        Window window = UnityPlayer.currentActivity.getWindow();
    //    //
    //    //        WindowManager.LayoutParams layoutParams = window.getAttributes();
    //    //        layoutParams.screenBrightness = brightness;
    //    //        window.setAttributes(layoutParams);
    //    //    }
    //    //});
    //}
}
