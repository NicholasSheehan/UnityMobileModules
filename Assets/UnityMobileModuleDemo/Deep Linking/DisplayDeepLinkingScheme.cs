﻿using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules.Demo
{
    [RequireComponent(typeof(Text))]
    public class DisplayDeepLinkingScheme : MonoBehaviour
    {
        /// <summary>
        /// Text that displays the Deep Link scheme
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
            displayText.text = DeepLinking.scheme;
        }
    }
}
