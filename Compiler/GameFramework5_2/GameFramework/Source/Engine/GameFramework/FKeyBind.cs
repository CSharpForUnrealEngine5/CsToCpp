#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/PlayerInput.h")]
///<summary>Struct containing mappings for legacy method of binding keys to exec commands.</summary>
public partial struct FKeyBind {
// KeyBind
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
