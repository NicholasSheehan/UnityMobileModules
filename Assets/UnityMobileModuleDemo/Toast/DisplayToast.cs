using UnityEngine;
using UnityEngine.UI;
using UnityMobileModules;

namespace UnityMobileModuleDemo.Demo
{
    public class DisplayToast : MonoBehaviour
    {
        /// <summary>
        /// Toast Text Input Field
        /// </summary>
        [SerializeField] InputField toastTextInputField;

        /// <summary>
        /// Displays a short toast
        /// </summary>
        public void DisplayShort()
        {
            Toast.ShowToast(toastTextInputField.text, Toast.ToastLength.Short);
        }

        /// <summary>
        /// Displays a long toast
        /// </summary>
        public void DisplayLong()
        {
            Toast.ShowToast(toastTextInputField.text, Toast.ToastLength.Long);
        }
    }
}
