# Keyboard
Software keyboard state of the device

## API
##### `Keyboard.isSupported`
`public static bool isSupported;`

[Example Script]()

##### `Keyboard.isVisible`
`public static bool isVisible;`

[Example Script]()

##### `Keyboard.Open(string, TouchScreenKeyboardType, bool, bool, bool, bool, string)`
`public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType = TouchScreenKeyboardType.Default, bool autocorrection = true, bool multiline = false, bool secure = false, bool alert = false, string textPlaceholder = "/"/"");`

[Example Script]()

## Refrences
[Unity Docs](https://docs.unity3d.com/2017.1/Documentation/ScriptReference/TouchScreenKeyboard.html)

## Notes
* Unity 2017.1+
* Just a wrapper for an existing in Unity function, making it easier to find and use.