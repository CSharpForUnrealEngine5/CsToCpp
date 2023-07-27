#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimExecutionContextLibrary.h")]
///<summary>Exposes operations to be performed on anim node contexts</summary>
public partial class UAnimExecutionContextLibrary : UBlueprintFunctionLibrary {
// AnimExecutionContextLibrary
	public  void Prototype_ThreadSafeAnimNodeCall(FAnimExecutionContext Context,FAnimNodeReference Node) {}
	public  void Prototype_ThreadSafeAnimUpdateCall(FAnimUpdateContext Context,FAnimNodeReference Node) {}
	public static UAnimInstance GetAnimInstance(FAnimExecutionContext Context) { return default; }
	public static FAnimNodeReference GetAnimNodeReference(UAnimInstance Instance,int Index) { return default; }
	public static FAnimInitializationContext ConvertToInitializationContext(FAnimExecutionContext Context,EAnimExecutionContextConversionResult Result) { return default; }
	public static FAnimUpdateContext ConvertToUpdateContext(FAnimExecutionContext Context,EAnimExecutionContextConversionResult Result) { return default; }
	public static float GetDeltaTime(FAnimUpdateContext Context) { return default; }
	public static float GetCurrentWeight(FAnimUpdateContext Context) { return default; }
	public static FAnimPoseContext ConvertToPoseContext(FAnimExecutionContext Context,EAnimExecutionContextConversionResult Result) { return default; }
	public static FAnimComponentSpacePoseContext ConvertToComponentSpacePoseContext(FAnimExecutionContext Context,EAnimExecutionContextConversionResult Result) { return default; }
}
