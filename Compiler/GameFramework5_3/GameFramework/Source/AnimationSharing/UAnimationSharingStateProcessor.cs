namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingTypes.h")]
public partial class UAnimationSharingStateProcessor : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ProcessActorState</summary>
	public void ProcessActorState(int OutState,AActor InActor,byte CurrentState,byte OnDemandState,bool bShouldProcess) {}
	///<summary>GetAnimationStateEnum</summary>
	public UEnum GetAnimationStateEnum() { return default; }
	///<summary>AnimationStateEnum</summary>
	public TSoftObjectPtr<UEnum> AnimationStateEnum;
}
