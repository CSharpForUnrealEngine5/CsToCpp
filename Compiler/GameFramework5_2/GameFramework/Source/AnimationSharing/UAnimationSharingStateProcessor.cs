#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingTypes.h")]
public partial class UAnimationSharingStateProcessor : UObject {
// AnimationSharingStateProcessor
	public  void ProcessActorState(int OutState,AActor InActor,byte CurrentState,byte OnDemandState,bool bShouldProcess) {}
	public  UEnum GetAnimationStateEnum() { return default; }
	public TSoftObjectPtr<UEnum> AnimationStateEnum;
}
