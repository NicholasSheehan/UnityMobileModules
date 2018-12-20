﻿using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules.Demo
{
    [RequireComponent(typeof(Text))]
    public class DisplayNormalizedRingerVolume : MonoBehaviour
    {
        /// <summary>
        /// Text to display
        /// </summary>
        Text statusText;

        void Awake()
        {
            statusText = GetComponent<Text>();
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
            statusText.text = Volume.ringerNormalizedPercent.ToString();
        }
    }
}
