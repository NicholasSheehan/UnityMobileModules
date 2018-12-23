using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules.Demo
{
    [RequireComponent(typeof(Button))]
    public class OpenKeyboard : MonoBehaviour
    {
        /// <summary>
        /// Opens the keyboard, called via button
        /// </summary>
        public void Open_Keyboard()
        {
            Keyboard.Open("");
        }
    }
}
