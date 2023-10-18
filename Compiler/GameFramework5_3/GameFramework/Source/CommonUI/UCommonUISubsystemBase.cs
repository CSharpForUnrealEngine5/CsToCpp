namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonUISubsystemBase.h")]
public partial class UCommonUISubsystemBase : UGameInstanceSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Gets Action Button Icon for current gamepad</summary>
	public FSlateBrush GetInputActionButtonIcon(FDataTableRowHandle InputActionRowHandle,ECommonInputType InputType,FName GamepadName) { return default; }
	///<summary>Gets Action Button Icon for given action and player, enhanced input API currently does not allow input type specification</summary>
	public FSlateBrush GetEnhancedInputActionButtonIcon(UInputAction InputAction,ULocalPlayer LocalPlayer) { return default; }
}
