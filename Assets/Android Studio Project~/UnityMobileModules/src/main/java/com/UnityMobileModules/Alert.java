package com.UnityMobileModules;

import com.unity3d.player.UnityPlayer;
import android.app.AlertDialog;
import android.content.DialogInterface;

public class Alert
{
    /**
     *  Shows a alert to the user
     * @param alertTitle - Title of the alert
     * @param alertBody - Text of the alert
     * @param cancelButtonText - Text to display on the cancel button
     */
    public static void ShowAlert(String alertTitle, String alertBody, String cancelButtonText)
    {
        AlertDialog.Builder builder = new AlertDialog.Builder(UnityPlayer.currentActivity);
        builder.setTitle(alertTitle)
                .setMessage(alertBody)
                .setCancelable(false)
                .setPositiveButton(cancelButtonText, new DialogInterface.OnClickListener() {
                    //by default doing nothing just closes the dialog
                    //this does nothing, it can do stuff though
                    public void onClick(DialogInterface dialog, int id) {}
                });
        AlertDialog alert = builder.create();
        alert.show();
    }
}
