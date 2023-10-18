namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines values for hold behavior per input type: for mouse Press and Hold, for gamepad focused Press and Hold, for touch Press and Hold.</summary>
[CppInclude("CommonInputBaseTypes.h")]
public partial class UCommonUIHoldData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>KeyboardAndMouse</summary>
	public FInputHoldData KeyboardAndMouse;
	///<summary>Gamepad</summary>
	public FInputHoldData Gamepad;
	///<summary>Touch</summary>
	public FInputHoldData Touch;
}
