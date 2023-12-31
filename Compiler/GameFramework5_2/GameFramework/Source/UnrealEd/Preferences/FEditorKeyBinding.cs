namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An editor hotkey binding to a parameterless exec.</summary>
[CppInclude("Preferences/UnrealEdKeyBindings.h")]
public partial struct FEditorKeyBinding {
	public bool bCtrlDown;
	public bool bAltDown;
	public bool bShiftDown;
	public FKey Key;
	public FName CommandName;
}
