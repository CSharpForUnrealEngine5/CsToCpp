#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingTypes.h")]
public partial class UAnimationSharingStateProcessor : UObject {
	///<summary>ProcessActorState</summary>
	public  void ProcessActorState(int OutState,AActor InActor,byte CurrentState,byte OnDemandState,bool bShouldProcess) {}
	///<summary>GetAnimationStateEnum</summary>
	public  UEnum GetAnimationStateEnum() { return default; }
	///<summary>AnimationStateEnum</summary>
	public TSoftObjectPtr<UEnum> AnimationStateEnum;
}
