namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A parameterless exec command that can be bound to hotkeys and menu items in the editor.</summary>
[CppInclude("Preferences/UnrealEdOptions.h")]
public partial struct FEditorCommand {
	public FName Parent;
	public FName CommandName;
	public string ExecCommand;
	public string Description;
}
