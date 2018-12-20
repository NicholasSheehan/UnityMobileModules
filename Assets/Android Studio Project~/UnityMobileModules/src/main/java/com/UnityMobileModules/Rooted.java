package com.UnityMobileModules;

import java.io.File;

public class Rooted {

    /**
     * Checks to see if specific rooted binaries are present
     * @return - True if rooted specific binaries are present
     */
    public static boolean IsRooted(){
        return findBinary("su");
    }

    /**
     * Tries to find a binary
     * @param binaryName - Name of the binary to find
     * @return - True if the binary is found
     */
    static boolean findBinary(String binaryName) {
        String[] places = {
            "/sbin/",
            "/system/bin/",
            "/system/xbin/",
            "/data/local/xbin/",
            "/data/local/bin/",
            "/system/sd/xbin/",
            "/system/bin/failsafe/",
            "/data/local/"
        };

        for (String where : places) {
            if (new File(where + binaryName).exists()) {
                return true;
            }
        }

        return false;
    }
}
