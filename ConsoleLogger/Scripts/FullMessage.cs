using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FullMessage : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Image separationBar;
    private string logString;
    private string stackTrace;
    private LogType type;

    public void NewFullMessage(string _logString, string _stackTrace, LogType _type)
    {
        logString = _logString;
        stackTrace = _stackTrace;
        type = _type;
        switch(type)
        {
            case LogType.Log:
                separationBar.color = new Color(0.4117647f, 0.7450981f, 1, 1);
                break;
            case LogType.Warning:
                separationBar.color = new Color(1, 0.8941177f, 0.627451f, 1);
                break;
            case LogType.Exception:
            case LogType.Error:
                separationBar.color = new Color(0.9607844f, 0.3411765f, 0.3843138f, 1);
                break;
            case LogType.Assert:
                separationBar.color = new Color(1, 1, 1, 1);
                break;
            default:
                throw new NotImplementedException($"LogType {type} is not implemented.");
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        ConsoleUI.Instance.fullTrace.OpenNewFullTrace(logString, stackTrace);
        ConsoleUI.Instance.fullTrace.gameObject.SetActive(true);
    }
}
