using UnityEngine;
using System;
using TMPro;

namespace Maffin.RuntimeConsole
{
    public class ConsoleLogger : MonoBehaviour
    {
        private static ConsoleLogger _instance;

        public static ConsoleLogger Instance
        {
            get => _instance;
            set
            {
                if (_instance != null)
                {
                    Debug.LogWarning("ConsoleLogger instance already exists. Destroying the new instance.");
                    Destroy(value.gameObject);
                }
                _instance = value;
                DontDestroyOnLoad(_instance);
            }
        }

        private void Awake()
        {
            Instance = this;
        }

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
}