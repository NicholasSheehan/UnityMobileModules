package com.UnityMobileModules;

import android.content.Intent;
import android.net.Uri;

import com.unity3d.player.UnityPlayer;

public class DeepLinking {

    /**
     * Returns the deep link URI used to start the app
     * @return - Deep Link URI
     */
    public static String GetDeepLinkURI()
    {
        Intent intent = UnityPlayer.currentActivity.getIntent();
        Uri data = intent.getData();

        if(data == null) return "";

        return data.toString();
    }
}
