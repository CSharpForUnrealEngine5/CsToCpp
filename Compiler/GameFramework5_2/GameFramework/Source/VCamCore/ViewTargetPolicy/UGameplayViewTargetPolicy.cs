#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A gameplay view target policy determines which player controller should change its view target when gameplay is started,</summary>
[CppInclude("ViewTargetPolicy/GameplayViewTargetPolicy.h")]
public partial class UGameplayViewTargetPolicy : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Called when the policy should be applied: when the output provider&#39;s activation changes in a game world.</summary>
	public  TArray<APlayerController> DeterminePlayerControllers(FDeterminePlayerControllersTargetPolicyParams Params) { return default; }
	///<summary>Called to just after the view target has been updated for the player controller that was previously returned by DeterminePlayerController.</summary>
	public  void UpdateViewTarget(FUpdateViewTargetPolicyParams Params) {}
}
