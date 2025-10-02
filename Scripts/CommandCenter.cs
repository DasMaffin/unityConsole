using System;
using System.Collections.Generic;
using UnityEngine;

public static class CommandCenter
{
    private static Dictionary<string, Action> commands = new Dictionary<string, Action>();

    /// <summary>
    /// Adds a command to the list of possible commands.
    /// </summary>
    /// <param name="name">The, not case sensitive, name of the command. This is the string you type into the console to trigger it.</param>
    /// <param name="action">The method to be executed when the command is used.</param>
    public static void AddCommand(string name, Action action)
    {
        if (!commands.ContainsKey(name.ToLower()))
        {
            commands[name.ToLower()] = action;
            Debug.Log($"Command '{name}' added.");
        }
        else
        {
            Debug.LogWarning($"Command '{name}' already exists. Overwriting.");
            commands[name.ToLower()] = action;
        }
    }

    public static void Execute(string input)
    {
        if (commands.TryGetValue(input.ToLower(), out var action))
        {
            action.Invoke();
        }
        else
        {
            Debug.Log($"Unknown command: {input}");
        }
    }
}
