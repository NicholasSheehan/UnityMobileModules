using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules.Demo
{
    [RequireComponent(typeof(Text))]
    public class DisplayAppValidityState : MonoBehaviour
    {
        /// <summary>
        /// State Text
        /// </summary>
        Text stateText;

        void Awake()
        {
            stateText = GetComponent<Text>();
        }

        void Start()
        {
            UpdateText();
        }

        /// <summary>
        /// Updates the AppValidity state
        /// </summary>
        void UpdateText()
        {
            stateText.text = AppValidity.validityState.ToString();
        }
    }
}
