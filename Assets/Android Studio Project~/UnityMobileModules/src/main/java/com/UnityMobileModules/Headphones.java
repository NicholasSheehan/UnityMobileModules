//package com.UnityMobileModules;
//
//import android.content.Context;
//import android.media.AudioDeviceInfo;
//import android.media.AudioManager;
//
//import com.unity3d.player.UnityPlayer;
//
//public class Headphones {
//
//    public static boolean isHeadphonesPlugged(){
//
//        AudioManager audioManager = (AudioManager)UnityPlayer.currentActivity.getSystemService(Context.AUDIO_SERVICE);
//        return audioManager.isWiredHeadsetOn();
//
////        AudioManager audioManager = (AudioManager)UnityPlayer.currentActivity.getSystemService(Context.AUDIO_SERVICE);
////        AudioDeviceInfo[] audioDevices = audioManager.getDevices(AudioManager.GET_DEVICES_ALL);
////        for(AudioDeviceInfo deviceInfo : audioDevices){
////            if(deviceInfo.getType()==AudioDeviceInfo.TYPE_WIRED_HEADPHONES || deviceInfo.getType()==AudioDeviceInfo.TYPE_WIRED_HEADSET){
////                return true;
////            }
////        }
////        return false;
//    }
//}
