using UnityEngine;
using UnityEngine.EventSystems;

public class FullMessage : MonoBehaviour, IPointerClickHandler
{
    string logString;
    string stackTrace;
    LogType type;

    public void NewFullMessage(string _logString, string _stackTrace, LogType _type)
    {
        logString = _logString;
        stackTrace = _stackTrace;
        type = _type;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        ConsoleUI.Instance.fullTrace.OpenNewFullTrace(logString, stackTrace);
        ConsoleUI.Instance.fullTrace.gameObject.SetActive(true);
    }
}
