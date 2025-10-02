The console will automatically print anything and everything that you would find in the "Console" tab in the editor. You can click any entry to see the details.

Drag and drop Prefabs/ConsoleCanvas into the scene for the console.
To add commands register them with the provided CommandCenter.AddCommand(string, Action). The string is the command that is entered. This is not case sensitive. The action is the method to be called when the command is entered into the console.

Check out the Prefabs/ExampleCommandManager for an example of how you may implement a new command. You can drag and drop the asset into the scene anywhere and then use the commands 'dance' and 'close console'. Check out Scripts/ExampleCommandManager for the example script.

Test
