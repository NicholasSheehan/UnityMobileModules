using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules.Demo
{
    [RequireComponent(typeof(Text))]
    public class DisplayBrightnessLevel : MonoBehaviour
    {
        /// <summary>
        /// Text to display the brightness level
        /// </summary>
        Text brightnessText;

        void Awake()
        {
            brightnessText = GetComponent<Text>();
            SetBrightnessText();
        }

        void Update()
        {
            SetBrightnessText();
        }

        /// <summary>
        /// Sets the brightness text
        /// </summary>
        void SetBrightnessText()
        {
            brightnessText.text = Brightness.brightness + "%";
        }
    }
}
