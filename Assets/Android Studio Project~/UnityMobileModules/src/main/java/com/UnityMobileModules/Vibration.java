package com.UnityMobileModules;

import android.content.Context;
import android.os.Build;
import android.os.VibrationEffect;
import android.os.Vibrator;

import com.unity3d.player.UnityPlayer;

public class Vibration {

    /**
     * Vibrates the device with amplitude
     * @param milliseconds - Milliseconds to vibrate for
     * @param amplitude - Strength of the vibration
     */
    public static void Vibrate(long milliseconds, int amplitude) {
        Vibrator vib = (Vibrator) UnityPlayer.currentActivity.getSystemService(Context.VIBRATOR_SERVICE);

        if(Build.VERSION.SDK_INT >= android.os.Build.VERSION_CODES.O) vib.vibrate(VibrationEffect.createOneShot(milliseconds, amplitude));
        else vib.vibrate(milliseconds);
    }

    /**
     * Creates a vibration pattern with amplitudes
     * @param timings - Timings of the vibration
     * @param amplitudes - Strength of the vibrations
     * @param repeat - Index to start the repeat, -1 to never repeat
     */
    public static void VibratePattern(long[] timings, int[] amplitudes, int repeat) {
        Vibrator vib = (Vibrator) UnityPlayer.currentActivity.getSystemService(Context.VIBRATOR_SERVICE);

        if(Build.VERSION.SDK_INT >= android.os.Build.VERSION_CODES.O) vib.vibrate(VibrationEffect.createWaveform(timings, amplitudes, repeat));
        else vib.vibrate(timings, repeat);
    }
}
