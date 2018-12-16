using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules.Demo
{
    [RequireComponent(typeof(Text))]
    public class DisplayBluetoothEnabled : MonoBehaviour
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

        void Update()
        {
            UpdateText();
        }

        /// <summary>
        /// Updates the text
        /// </summary>
        void UpdateText()
        {
            supportedText.text = Bluetooth.isEnabled.ToString();
        }
    }
}
