using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules.Demo
{
    [RequireComponent(typeof(Text))]
    public class DisplayIsKeyboardVisible : MonoBehaviour
    {
        /// <summary>
        /// Text that displays the status
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

        void UpdateText()
        {
            statusText.text = Keyboard.isVisible.ToString();
        }
    }
}
