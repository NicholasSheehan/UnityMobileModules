using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules.Demo
{
    [RequireComponent(typeof(Text))]
    public class DisplayBatteryStatus : MonoBehaviour
    {
        /// <summary>
        /// Text to display the brightness level
        /// </summary>
        Text batteryStatusText;

        void Awake()
        {
            batteryStatusText = GetComponent<Text>();
            SetBatteryStatus();
        }

        void Update()
        {
            SetBatteryStatus();
        }

        /// <summary>
        /// Sets the brightness text
        /// </summary>
        void SetBatteryStatus()
        {
            batteryStatusText.text = Battery.batteryStatus.ToString();
        }
    }
}
