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
	///<summary>The user settings object that we can use to test. Normally this is owned by the EI Local Player subsystem</summary>
	public UEnhancedInputUserSettings UserSettings;
}
