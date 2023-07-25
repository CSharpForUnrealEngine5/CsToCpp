#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Preferences/UnrealEdOptions.h")]
///<summary>A parameterless exec command that can be bound to hotkeys and menu items in the editor.</summary>
public partial struct FEditorCommand {
// EditorCommand
	public string Parent;
	public string CommandName;
	public string ExecCommand;
	public string Description;
}
