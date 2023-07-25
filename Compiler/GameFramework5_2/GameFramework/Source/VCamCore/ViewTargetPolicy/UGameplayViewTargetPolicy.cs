#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewTargetPolicy/GameplayViewTargetPolicy.h")]
///<summary>A gameplay view target policy determines which player controller should change its view target when gameplay is started,</summary>
public partial class UGameplayViewTargetPolicy : UObject {
// GameplayViewTargetPolicy
	public TArray<UObject> DeterminePlayerControllers(FDeterminePlayerControllersTargetPolicyParams Params) { return default; }
	public void UpdateViewTarget(FUpdateViewTargetPolicyParams Params) {}
}
