namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNotifies/AnimNotifyState.h")]
public partial class UAnimNotifyState : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Implementable event to get a custom name for the notify</summary>
	public string GetNotifyName() { return default; }
	///<summary>Received_NotifyBegin</summary>
	public bool Received_NotifyBegin(USkeletalMeshComponent MeshComp,UAnimSequenceBase Animation,float TotalDuration,FAnimNotifyEventReference EventReference) { return default; }
	///<summary>Received_NotifyTick</summary>
	public bool Received_NotifyTick(USkeletalMeshComponent MeshComp,UAnimSequenceBase Animation,float FrameDeltaTime,FAnimNotifyEventReference EventReference) { return default; }
	///<summary>Received_NotifyEnd</summary>
	public bool Received_NotifyEnd(USkeletalMeshComponent MeshComp,UAnimSequenceBase Animation,FAnimNotifyEventReference EventReference) { return default; }
	///<summary>Color of Notify in editor</summary>
	public FColor NotifyColor;
	///<summary>Whether this notify state instance should fire in animation editors</summary>
	public bool bShouldFireInEditor;
	///<summary>TriggerWeightThreshold to use when creating notifies of this type</summary>
	public float GetDefaultTriggerWeightThreshold() { return default; }
}
