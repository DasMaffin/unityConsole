using UnityEngine;

namespace Maffin.RuntimeConsole
{
    public class ExampleCommandManager : MonoBehaviour
    {
        private void Start()
        {
            CommandCenter.AddCommand("dance", (value) =>
            {
                Debug.Log("You are now dancing. Whatever that may entail...");
            });

            CommandCenter.AddCommand("close console", ConsoleUI.Instance.ToggleConsole);
        }
    }
}