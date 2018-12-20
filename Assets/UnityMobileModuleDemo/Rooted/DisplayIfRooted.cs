using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules.Demo
{
    [RequireComponent(typeof(Text))]
    public class DisplayIfRooted : MonoBehaviour
    {
        /// <summary>
        /// Text to display if the device is rooted
        /// </summary>
        Text statusText;

        void Awake()
        {
            statusText = GetComponent<Text>();
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
            statusText.text = Rooted.isRooted.ToString();
        }
    }
}
