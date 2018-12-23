using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityMobileModules
{
	/// <summary>
	/// Software based keyboard informtation
	/// </summary>
    public static class Keyboard
    {
        /// <summary>
        /// Is the software keyboard supported
        /// </summary>
        public static bool isSupported
        {
            get
            {
                return TouchScreenKeyboard.isSupported;
            }
        }

        /// <summary>
        /// Is the software keyboard visible
        /// </summary>
        public static bool isVisible
        {
            get
            {
                return TouchScreenKeyboard.visible;
            }
        }

        /// <summary>
        /// Opens a software keyboard on the screen
        /// </summary>
        /// <param name="text">	Text to edit.</param>
        /// <param name="keyboardType">Type of keyboard (eg, any text, numbers only, etc).</param>
        /// <param name="autocorrection">Is autocorrection applied?</param>
        /// <param name="multiline">Can more than one line of text be entered?</param>
        /// <param name="secure">Is the text masked (for passwords, etc)?</param>
        /// <param name="alert">Is the keyboard opened in alert mode?</param>
        /// <param name="textPlaceholder">Text to be used if no other text is present.</param>
        /// <returns></returns>
        public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType = TouchScreenKeyboardType.Default, bool autocorrection = true, bool multiline = false, bool secure = false, bool alert = false, string textPlaceholder = "\"\"")
        {
            return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert);
        }
    }
}
