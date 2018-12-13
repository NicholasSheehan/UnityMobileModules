using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules.Demo
{
    public class DisplayAlert : MonoBehaviour
    {
        /// <summary>
        /// Alert Title Input Field
        /// </summary>
        [SerializeField] InputField alertTitleInputField;

        /// <summary>
        /// Alert Body Input Field
        /// </summary>
        [SerializeField] InputField alertBodyInputField;

        /// <summary>
        /// Cancel Text Input Field
        /// </summary>
        [SerializeField] InputField cancelTextInputField;

        /// <summary>
        /// Displays the alert
        /// </summary>
        public void Display()
        {
            Alert.ShowAlert(alertTitleInputField.text, alertBodyInputField.text, cancelTextInputField.text);
        }
    }
}
