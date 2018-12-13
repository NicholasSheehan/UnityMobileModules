using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules.Demo
{
    [RequireComponent(typeof(Text))]
    public class DisplayAirplaneModeState : MonoBehaviour
    {
        /// <summary>
        /// Airplane Mode Text
        /// </summary>
        Text airplaneModeText;

        void Awake()
        {
            airplaneModeText = GetComponent<Text>();
        }

        void Update()
        {
            UpdateText();
        }

        /// <summary>
        /// Updates the Airplane Mode text
        /// </summary>
        void UpdateText()
        {
            airplaneModeText.text = AirplaneMode.isAirplaneModeOn.ToString();
        }
    }
}
