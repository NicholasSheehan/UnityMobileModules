using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules.Demo
{
    [RequireComponent(typeof(Text))]
    public class DisplayDeepLinkingHost : MonoBehaviour
    {
        /// <summary>
        /// Text that displays the Deep Link host
        /// </summary>
        Text displayText;

        void Awake()
        {
            displayText = GetComponent<Text>();
        }

        void Start()
        {
            UpdateText();
        }

        void UpdateText()
        {
            displayText.text = DeepLinking.host;
        }
    }
}
