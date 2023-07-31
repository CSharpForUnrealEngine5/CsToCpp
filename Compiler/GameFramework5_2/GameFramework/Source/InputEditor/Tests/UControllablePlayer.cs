#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/InputTestFramework.h")]
public partial class UControllablePlayer : UObject {
	///<summary>Player</summary>
	public APlayerController Player;
	///<summary>BindingTargets</summary>
	public TMap<string,FBindingTargets> BindingTargets;
	///<summary>Storage for input mapping contexts applied to the player</summary>
	public TMap<string,UInputMappingContext> InputContext;
	///<summary>Storage for input actions applied to the player</summary>
	public TMap<string,UInputAction> InputAction;
}
