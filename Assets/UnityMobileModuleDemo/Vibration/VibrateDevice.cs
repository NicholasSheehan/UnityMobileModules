using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules.Demo
{
    [RequireComponent(typeof(Button))]
    public class VibrateDevice : MonoBehaviour
    {
        /// <summary>
        /// Vibration Type
        /// </summary>
        [SerializeField] VibrationType vibrationType;

        /// <summary>
        /// Vibrates the device, called via button
        /// </summary>
        public void Vibrate()
        {
            Vibration.Vibrate(vibrationType);
        }
    }
}
