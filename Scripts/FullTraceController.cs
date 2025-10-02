using TMPro;
using UnityEngine;

namespace Maffin.RuntimeConsole
{
    public class FullTraceController : MonoBehaviour
    {
        public string fullTraceTitleString = "No trace available.";
        public string fullTraceTextString = "No trace available.";

        public TextMeshProUGUI fullTraceTitle;
        public TextMeshProUGUI fullTraceText;

        public void OpenNewFullTrace(string fullTraceTitleString, string fullTraceTextString)
        {
            this.fullTraceTitleString = fullTraceTitleString;
            this.fullTraceTextString = fullTraceTextString;

            OnEnable();
        }

        private void Start()
        {
            CloseFullTrace();
        }

        private void OnEnable()
        {
            fullTraceTitle.text = fullTraceTitleString;
            fullTraceText.text = fullTraceTextString;
        }

        public void CloseFullTrace()
        {
            gameObject.SetActive(false);
        }
    }
}