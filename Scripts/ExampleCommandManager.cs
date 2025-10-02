using UnityEngine;

public class ExampleCommandManager : MonoBehaviour
{
    private void Start()
    {
        CommandCenter.AddCommand("dance", () =>
        {
            Debug.Log("You are now dancing. Whatever that may entail...");
        });

        CommandCenter.AddCommand("close console", ConsoleUI.Instance.ToggleConsole);
    }
}
