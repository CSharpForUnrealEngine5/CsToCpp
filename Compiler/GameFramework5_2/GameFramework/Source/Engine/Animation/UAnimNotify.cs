#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNotifies/AnimNotify.h")]
public partial class UAnimNotify : UObject {
// AnimNotify
	public string GetNotifyName() { return default; }
	public bool Received_Notify(UObject MeshComp,UObject Animation,FAnimNotifyEventReference EventReference) { return default; }
	public FColor NotifyColor;
	public bool bShouldFireInEditor;
	public float GetDefaultTriggerWeightThreshold() { return default; }
}
