#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNotifies/AnimNotify.h")]
public partial class UAnimNotify : UObject {
	///<summary>Implementable event to get a custom name for the notify</summary>
	public  string GetNotifyName() { return default; }
	///<summary>Received_Notify</summary>
	public  bool Received_Notify(USkeletalMeshComponent MeshComp,UAnimSequenceBase Animation,FAnimNotifyEventReference EventReference) { return default; }
	///<summary>Color of Notify in editor</summary>
	public FColor NotifyColor;
	///<summary>Whether this notify instance should fire in animation editors</summary>
	public bool bShouldFireInEditor;
	///<summary>TriggerWeightThreshold to use when creating notifies of this type</summary>
	public  float GetDefaultTriggerWeightThreshold() { return default; }
}
