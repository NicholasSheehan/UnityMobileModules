using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules.Demo
{
    [RequireComponent(typeof(Text))]
    public class DisplayIfLanConnection : MonoBehaviour
    {
        /// <summary>
        /// Text that displays if the device is connected to a lan network
        /// </summary>
        Text statusText;

        void Awake()
        {
            statusText = GetComponent<Text>();
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
            statusText.text = Internet.connectedToLan.ToString();
        }
    }
}
