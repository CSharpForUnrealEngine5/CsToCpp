#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/PlayerInput.h")]
///<summary>Defines a mapping between an action and key</summary>
public partial struct FInputActionKeyMapping {
// InputActionKeyMapping
	public string ActionName;
	public bool bShift;
	public bool bCtrl;
	public bool bAlt;
	public bool bCmd;
	public FKey Key;
}
