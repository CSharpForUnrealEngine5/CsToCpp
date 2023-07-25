#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNotifies/AnimNotifyState.h")]
public partial class UAnimNotifyState : UObject {
// AnimNotifyState
	public string GetNotifyName() { return default; }
	public bool Received_NotifyBegin(UObject MeshComp,UObject Animation,float TotalDuration,FAnimNotifyEventReference EventReference) { return default; }
	public bool Received_NotifyTick(UObject MeshComp,UObject Animation,float FrameDeltaTime,FAnimNotifyEventReference EventReference) { return default; }
	public bool Received_NotifyEnd(UObject MeshComp,UObject Animation,FAnimNotifyEventReference EventReference) { return default; }
	public FColor NotifyColor;
	public bool bShouldFireInEditor;
	public float GetDefaultTriggerWeightThreshold() { return default; }
}
