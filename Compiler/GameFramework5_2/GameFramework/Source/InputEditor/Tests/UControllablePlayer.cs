namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/InputTestFramework.h")]
public partial class UControllablePlayer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Player</summary>
	public APlayerController Player;
	///<summary>BindingTargets</summary>
	public TMap<FName,FBindingTargets> BindingTargets;
	///<summary>Storage for input mapping contexts applied to the player</summary>
	public TMap<FName,UInputMappingContext> InputContext;
	///<summary>Storage for input actions applied to the player</summary>
	public TMap<FName,UInputAction> InputAction;
}
