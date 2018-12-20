using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules.Demo
{
    [RequireComponent(typeof(Text))]
    public class DisplayInternetState : MonoBehaviour
    {
        /// <summary>
        /// Text that displays the state of the internet connection
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
            statusText.text = Internet.internetState.ToString();
        }
    }
}
