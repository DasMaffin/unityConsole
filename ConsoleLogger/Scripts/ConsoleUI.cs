using System;
using TMPro;
using UnityEngine;

public class ConsoleUI : MonoBehaviour
{
    private static ConsoleUI instance;
    public static ConsoleUI Instance
    {
        get => instance;
        set
        {
            if(instance == null)
            {
                instance = value;
            }
            else
            {
                Destroy(value.gameObject);
            }
        }
    }

    public GameObject textEntry;

    public GameObject contentContianer;
    public FullTraceController fullTrace;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ConsoleLogger.OnConsoleMessage += DisplayMessage;
    }

    private void DisplayMessage(string logString, string stackTrace, LogType type)
    {
        GameObject textObject = Instantiate(textEntry, contentContianer.transform);
        textObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{logString}";
        textObject.GetComponent<FullMessage>().NewFullMessage(logString, stackTrace, type);
    }
}
