package com.UnityMobileModules;

import android.bluetooth.BluetoothAdapter;

public class Bluetooth {

    /**
     * Does the device support Bluetooth
     * @return - If the device supports Bluetooth
     */
    public static boolean DeviceSupportsBluetooth(){
        BluetoothAdapter mBluetoothAdapter = BluetoothAdapter.getDefaultAdapter();
        return mBluetoothAdapter != null;
    }

    /**
     * Is Bluetooth enabled?
     * @return - If Bluetooth is enabled
     */
    public static boolean IsEnabled(){
        BluetoothAdapter mBluetoothAdapter = BluetoothAdapter.getDefaultAdapter();
        //Requires android.permission.BLUETOOTH - Safe
        return mBluetoothAdapter.isEnabled();
    }

//    /**
//     * Are there any devices connected
//     * @return - All connected devices
//     */
//    public static String[] GetDevicesConnected(){
//        BluetoothAdapter mBluetoothAdapter = BluetoothAdapter.getDefaultAdapter();
//        Set<BluetoothDevice> pairedDevices = mBluetoothAdapter.getBondedDevices();
//
//        //List to return
//        ArrayList<String> devices = new ArrayList<>();
//
//        if (pairedDevices.size() > 0) {
//            for (BluetoothDevice device : pairedDevices) {
//                String deviceString = device.getName() + "|||" + device.getBluetoothClass().getMajorDeviceClass() + "|||" + device.getBluetoothClass().getDeviceClass();
//                devices.add(deviceString);
//            }
//        }
//
//        //Converts ArrayList to String[]
//        return devices.toArray(new String[0]);
//    }
}
