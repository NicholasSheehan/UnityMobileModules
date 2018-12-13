package com.UnityMobileModules;

import com.unity3d.player.UnityPlayer;

public class Toast {
    /**
     * Displays a toast to the user
     * @param toastText - Text to display on the toast
     * @param showLongToast - Should a long toast be shown?
     */
    public static void ShowToast(String toastText, boolean showLongToast)
    {
        android.widget.Toast.makeText(UnityPlayer.currentActivity, toastText, showLongToast ? android.widget.Toast.LENGTH_LONG : android.widget.Toast.LENGTH_SHORT).show();
    }
}
