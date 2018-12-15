using UnityEngine;
using UnityEngine.UI;

namespace UnityMobileModules.Demo
{
    [RequireComponent(typeof(Text))]
    public class DisplayAllInstalledAppPackageNames : MonoBehaviour
    {
        /// <summary>
        /// Text that displays the app information
        /// </summary>
        Text displayText;

        void Awake()
        {
            displayText = GetComponent<Text>();
        }

        void OnEnable()
        {
            UpdateText();
        }

        /// <summary>
        /// Update the text
        /// </summary>
        void UpdateText()
        {
            var appList = "";
            var apps = Apps.installedAppPackageNames;

            for (var i = 0; i < apps.Length; i++)
            {
                appList += apps[i];

                if (i <= apps.Length - 1) appList += "\r\n";
            }

            displayText.text = appList;
        }
    }
}
