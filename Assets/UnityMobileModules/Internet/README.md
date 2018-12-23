# Internet
Internet state of the device

## API
##### `Internet.validityState`
`public static NetworkReachability internetState;`

[Example Script](../../../Assets/UnityMobileModuleDemo/Internet/DisplayInternetState.cs)

##### `Internet.connectedToMobileNetwork`
`public static bool connectedToMobileNetwork;`

[Example Script](../../../Assets/UnityMobileModuleDemo/Internet/DisplayMobileConnection.cs)

##### `Internet.connectedToLan`
`public static bool connectedToLan;`

[Example Script](../../../Assets/UnityMobileModuleDemo/Internet/DisplayIfLanConnection.cs)

##### `Internet.connectedToInternet`
`public static bool connectedToInternet;`

[Example Script](../../../Assets/UnityMobileModuleDemo/Internet/DisplayIfConnectedToInternet.cs)

## References
[Unity Docs](https://docs.unity3d.com/2017.1/Documentation/ScriptReference/Application-internetReachability.html)

## Notes
* Unity 2017.1+
* Just a wrapper for an existing in Unity function, making it easier to find and use.