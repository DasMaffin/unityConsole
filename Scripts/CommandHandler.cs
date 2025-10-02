using TMPro;
using UnityEngine;

public class CommandHandler : MonoBehaviour
{
    TMP_InputField inputField;

    private void Awake()
    {
        inputField = GetComponent<TMP_InputField>();
    }

    public void OnSubmit(string text)
    {
        if (!string.IsNullOrWhiteSpace(text))
        {
            CommandCenter.Execute(text);
            inputField.text = "";
        }
    }
}
