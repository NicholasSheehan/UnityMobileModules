using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules.Demo
{
    [RequireComponent(typeof(Text))]
    public class DisplayNormalizedBatteryPercentage : MonoBehaviour
    {
        /// <summary>
        /// Text to display the brightness level
        /// </summary>
        Text batteryPercentText;

        void Awake()
        {
            batteryPercentText = GetComponent<Text>();
            SetBatteryPercent();
        }

        void Update()
        {
            SetBatteryPercent();
        }

        /// <summary>
        /// Sets the brightness text
        /// </summary>
        void SetBatteryPercent()
        {
            batteryPercentText.text = Battery.normalizedBatteryPercentage.ToString();
        }
    }
}
