using UnityEngine;
using System;
using TMPro;

public class ConsoleLogger : MonoBehaviour
{
    public static event Action<string, string, LogType> OnConsoleMessage;

    void OnEnable()
    {
        Application.logMessageReceived += HandleLog;
    }

    void OnDisable()
    {
        Application.logMessageReceived -= HandleLog;
    }

    void HandleLog(string logString, string stackTrace, LogType type)
    {
        OnConsoleMessage?.Invoke(logString, stackTrace, type);
    }
}
