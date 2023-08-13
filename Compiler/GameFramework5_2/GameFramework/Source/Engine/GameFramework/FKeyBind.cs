namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct containing mappings for legacy method of binding keys to exec commands.</summary>
[CppInclude("GameFramework/PlayerInput.h")]
public partial struct FKeyBind {
	public FKey Key;
	public string Command;
	public bool Control;
	public bool Shift;
	public bool Alt;
	public bool Cmd;
	public bool bIgnoreCtrl;
	public bool bIgnoreShift;
	public bool bIgnoreAlt;
	public bool bIgnoreCmd;
	public bool bDisabled;
}
