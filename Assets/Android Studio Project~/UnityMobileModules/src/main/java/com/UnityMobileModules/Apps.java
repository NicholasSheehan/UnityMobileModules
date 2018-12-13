package com.UnityMobileModules;

import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;

import com.unity3d.player.UnityPlayer;

import java.util.List;

public class Apps {
    /**
     * @return - All installed app bundle identifiers
     */
    public static String[] GetInstalledAppPackageNames() {

        PackageManager packageManager = UnityPlayer.currentActivity.getPackageManager();

        List<PackageInfo> installedPackages = packageManager.getInstalledPackages(PackageManager.GET_META_DATA);

        String[] installedPackageNames = new String[installedPackages.size()];

        for (int i = 0; i < installedPackages.size(); i++){
            PackageInfo info = installedPackages.get(i);
            installedPackageNames[i] = info.packageName;
        }

        return installedPackageNames;
    }

    /**
     * @return - All installed app names
     */
    public static String[] GetInstalledAppDisplayNames() {

        PackageManager packageManager = UnityPlayer.currentActivity.getPackageManager();

        List<PackageInfo> installedPackages = packageManager.getInstalledPackages(PackageManager.GET_META_DATA);

        String[] installedPackageNames = new String[installedPackages.size()];

        for (int i = 0; i < installedPackages.size(); i++){
            PackageInfo info = installedPackages.get(i);
            installedPackageNames[i] = info.applicationInfo.loadLabel(packageManager).toString();
        }

        return installedPackageNames;
    }
}
