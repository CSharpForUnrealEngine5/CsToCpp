#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimExecutionContextLibrary.h")]
///<summary>Exposes operations to be performed on anim node contexts</summary>
public partial class UAnimExecutionContextLibrary : UBlueprintFunctionLibrary {
// AnimExecutionContextLibrary
	public void Prototype_ThreadSafeAnimNodeCall(FAnimExecutionContext Context,FAnimNodeReference Node) {}
	public void Prototype_ThreadSafeAnimUpdateCall(FAnimUpdateContext Context,FAnimNodeReference Node) {}
	public UObject GetAnimInstance(FAnimExecutionContext Context) { return default; }
	public FAnimNodeReference GetAnimNodeReference(UObject Instance,int Index) { return default; }
	public FAnimInitializationContext ConvertToInitializationContext(FAnimExecutionContext Context,EAnimExecutionContextConversionResult Result) { return default; }
	public FAnimUpdateContext ConvertToUpdateContext(FAnimExecutionContext Context,EAnimExecutionContextConversionResult Result) { return default; }
	public float GetDeltaTime(FAnimUpdateContext Context) { return default; }
	public float GetCurrentWeight(FAnimUpdateContext Context) { return default; }
	public FAnimPoseContext ConvertToPoseContext(FAnimExecutionContext Context,EAnimExecutionContextConversionResult Result) { return default; }
	public FAnimComponentSpacePoseContext ConvertToComponentSpacePoseContext(FAnimExecutionContext Context,EAnimExecutionContextConversionResult Result) { return default; }
}
