# Battery
Returns all battery related information

## API
##### `Battery.isCharging`
`public static bool isCharging;`

##### `Battery.isPluggedIn`
`public static bool isPluggedIn;`

##### `Battery.batteryStatus`
`public static BatteryStatus batteryStatus;`

[Example Script](../../../Assets/UnityMobileModuleDemo/Battery/DisplayBatteryStatus.cs)

##### `Battery.normalizedBatteryPercentage`
`public static float normalizedBatteryPercentage;`

[Example Script](../../../Assets/UnityMobileModuleDemo/Battery/DisplayNormalizedBatteryPercentage.cs)

##### `Battery.batteryPercentage`
`public static float batteryPercentage;`

[Example Script](../../../Assets/UnityMobileModuleDemo/Battery/DisplayBatteryPercentage.cs)

## Refrences
[Battery Level - Unity Docs](https://docs.unity3d.com/2017.1/Documentation/ScriptReference/SystemInfo-batteryLevel.html)

[Battery Status - Unity Docs](https://docs.unity3d.com/2017.1/Documentation/ScriptReference/SystemInfo-batteryStatus.html)

## Notes
* Unity 2017.1+
* Just a wrapper for an existing in Unity function, making it easier to find and use.