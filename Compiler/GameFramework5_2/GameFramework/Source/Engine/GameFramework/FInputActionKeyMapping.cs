namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines a mapping between an action and key</summary>
[CppInclude("GameFramework/PlayerInput.h")]
public partial struct FInputActionKeyMapping {
	public string ActionName;
	public bool bShift;
	public bool bCtrl;
	public bool bAlt;
	public bool bCmd;
	public FKey Key;
}
