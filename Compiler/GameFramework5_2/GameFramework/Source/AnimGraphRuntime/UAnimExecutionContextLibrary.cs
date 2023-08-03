#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes operations to be performed on anim node contexts</summary>
[CppInclude("AnimExecutionContextLibrary.h")]
public partial class UAnimExecutionContextLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Prototype function for thread-safe anim node calls</summary>
	public  void Prototype_ThreadSafeAnimNodeCall(FAnimExecutionContext Context,FAnimNodeReference Node) {}
	///<summary>Prototype function for thread-safe anim update calls</summary>
	public  void Prototype_ThreadSafeAnimUpdateCall(FAnimUpdateContext Context,FAnimNodeReference Node) {}
	///<summary>Get the anim instance that hosts this context</summary>
	public static UAnimInstance GetAnimInstance(FAnimExecutionContext Context) { return default; }
	///<summary>Internal compiler use only - Get a reference to an anim node by index</summary>
	public static FAnimNodeReference GetAnimNodeReference(UAnimInstance Instance,int Index) { return default; }
	///<summary>Convert to an initialization context</summary>
	public static FAnimInitializationContext ConvertToInitializationContext(FAnimExecutionContext Context,EAnimExecutionContextConversionResult Result) { return default; }
	///<summary>Convert to an update context</summary>
	public static FAnimUpdateContext ConvertToUpdateContext(FAnimExecutionContext Context,EAnimExecutionContextConversionResult Result) { return default; }
	///<summary>Get the current delta time in seconds</summary>
	public static float GetDeltaTime(FAnimUpdateContext Context) { return default; }
	///<summary>Get the current weight of this branch of the graph</summary>
	public static float GetCurrentWeight(FAnimUpdateContext Context) { return default; }
	///<summary>Convert to a pose context</summary>
	public static FAnimPoseContext ConvertToPoseContext(FAnimExecutionContext Context,EAnimExecutionContextConversionResult Result) { return default; }
	///<summary>Convert to a component space pose context</summary>
	public static FAnimComponentSpacePoseContext ConvertToComponentSpacePoseContext(FAnimExecutionContext Context,EAnimExecutionContextConversionResult Result) { return default; }
}
