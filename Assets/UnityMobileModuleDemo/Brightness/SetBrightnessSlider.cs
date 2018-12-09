using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules.Demo
{
    [RequireComponent(typeof(Slider))]
    public class SetBrightnessSlider : MonoBehaviour
    {
        /// <summary>
        /// Brightness Slider
        /// </summary>
        Slider brightnessSlider;

        void Awake()
        {
            brightnessSlider = GetComponent<Slider>();
            brightnessSlider.value = Brightness.normalizedBrightness;
        }

        /// <summary>
        /// Sets the screens brightness, called via Slider event
        /// </summary>
        public void OnSliderValueChanged()
        {
            Brightness.normalizedBrightness = brightnessSlider.value;
        }
    }
}
