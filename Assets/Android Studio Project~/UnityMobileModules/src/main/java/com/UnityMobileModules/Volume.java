package com.UnityMobileModules;

import android.content.Context;
import android.media.AudioManager;

import com.unity3d.player.UnityPlayer;

public class Volume {

    /**
     * Gets the volume of a stream
     * @param flag - stream
     * @return - Volume of the stream
     */
    static int GetStreamVolume(int flag){
        AudioManager audio = (AudioManager) UnityPlayer.currentActivity.getSystemService(Context.AUDIO_SERVICE);
        return audio.getStreamVolume(flag);
    }

    /**
     * Gets the max volume of a stream
     * @param flag - stream
     * @return - Volume of the stream
     */
    static int GetStreamMaxVolume(int flag){
        AudioManager audio = (AudioManager) UnityPlayer.currentActivity.getSystemService(Context.AUDIO_SERVICE);
        return audio.getStreamMaxVolume(flag);
    }


    /**
     * Gets the ringer volume
     * @return - Ringer Volume
     */
    public static int GetRingerVolume(){
       return GetStreamVolume(AudioManager.STREAM_RING);
    }

    /**
     * Gets the max ringer volume
     * @return - Ringer Volume
     */
    public static int GetRingerMaxVolume(){
        return GetStreamMaxVolume(AudioManager.STREAM_RING);
    }


    /**
     * Gets the music volume
     * @return - Music Volume
     */
    public static int GetMusicVolume(){
        return GetStreamVolume(AudioManager.STREAM_MUSIC);
    }

    /**
     * Gets the max music volume
     * @return - Music Volume
     */
    public static int GetMusicMaxVolume(){
        return GetStreamMaxVolume(AudioManager.STREAM_MUSIC);
    }

    /**
     * Gets the alarm volume
     * @return - Alarm Volume
     */
    public static int GetAlarmVolume(){
        return GetStreamVolume(AudioManager.STREAM_ALARM);
    }

    /**
     * Gets the max alarm volume
     * @return - Alarm Volume
     */
    public static int GetAlarmMaxVolume(){
        return GetStreamMaxVolume(AudioManager.STREAM_ALARM);
    }
}
