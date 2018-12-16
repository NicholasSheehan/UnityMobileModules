using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules.Demo
{
    [RequireComponent(typeof(Text))]
    public class DisplayBluetoothSupported : MonoBehaviour
    {
        /// <summary>
        /// Text to display the brightness level
        /// </summary>
        Text supportedText;

        void Awake()
        {
            supportedText = GetComponent<Text>();
            UpdateText();
        }

        void Start()
        {
            UpdateText();
        }

        /// <summary>
        /// Updates the text
        /// </summary>
        void UpdateText()
        {
            supportedText.text = Bluetooth.deviceSupportsBluetooth.ToString();
        }
    }
}
