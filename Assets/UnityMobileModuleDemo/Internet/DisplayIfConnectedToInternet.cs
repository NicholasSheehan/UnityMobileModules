using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules
{
    [RequireComponent(typeof(Text))]
    public class DisplayIfConnectedToInternet : MonoBehaviour
    {
        /// <summary>
        /// Text that displays if the device is connected to the internet
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
            statusText.text = Internet.connectedToInternet.ToString();
        }
    }
}
