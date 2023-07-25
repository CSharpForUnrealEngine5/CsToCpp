#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Preferences/UnrealEdKeyBindings.h")]
///<summary>An editor hotkey binding to a parameterless exec.</summary>
public partial struct FEditorKeyBinding {
// EditorKeyBinding
	public bool bCtrlDown;
	public bool bAltDown;
	public bool bShiftDown;
	public FKey Key;
	public string CommandName;
}
