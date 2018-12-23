using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules.Demo
{
    [RequireComponent(typeof(Text))]
    public class DisplayIsKeyboardSupported : MonoBehaviour
    {
        /// <summary>
        /// Text that displays the status
        /// </summary>
        Text statusText;

        void Awake()
        {
            statusText = GetComponent<Text>();
        }

        void Start()
        {
            UpdateText();
        }

        void UpdateText()
        {
            statusText.text = Keyboard.isSupported.ToString();
        }
    }
}
