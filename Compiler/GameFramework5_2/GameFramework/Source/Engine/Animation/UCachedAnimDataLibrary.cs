#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A library of commonly used functionality from the CachedAnimData family, exposed to blueprint.</summary>
[CppInclude("Animation/CachedAnimDataLibrary.h")]
public partial class UCachedAnimDataLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns whether a state is relevant (specified in the provided FCachedAnimStateData)</summary>
	public static bool StateMachine_IsStateRelevant(UAnimInstance InAnimInstance,FCachedAnimStateData CachedAnimStateData) { return default; }
	///<summary>Returns the weight of a state, relative to its state machine (specified in the provided FCachedAnimStateData)</summary>
	public static float StateMachine_GetLocalWeight(UAnimInstance InAnimInstance,FCachedAnimStateData CachedAnimStateData) { return default; }
	///<summary>Returns the weight of a state, relative to the graph (specified in the provided FCachedAnimStateData)</summary>
	public static float StateMachine_GetGlobalWeight(UAnimInstance InAnimInstance,FCachedAnimStateData CachedAnimStateData) { return default; }
}
