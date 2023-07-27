#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConstraintsScripting.h")]
///<summary>This is a set of helper functions to access various parts of the Sequencer and Control Rig API via Python and Blueprints.</summary>
public partial class UConstraintsScriptingLibrary : UBlueprintFunctionLibrary {
// ConstraintsScriptingLibrary
	public static UConstraintsManager GetManager(UWorld InWorld) { return default; }
	public static UTransformableComponentHandle CreateTransformableComponentHandle(UWorld InWorld,USceneComponent InSceneComponent,string InSocketName) { return default; }
	public static UTransformableHandle CreateTransformableHandle(UWorld InWorld,UObject InObject,string InAttachmentName/*=NAME_None*/) { return default; }
	public static UTickableTransformConstraint CreateFromType(UWorld InWorld,ETransformConstraintType InType) { return default; }
	public static bool AddConstraint(UWorld InWorld,UTransformableHandle InParentHandle,UTransformableHandle InChildHandle,UTickableTransformConstraint InConstraint,bool bMaintainOffset) { return default; }
	public static TArray<UTickableConstraint> GetConstraintsArray(UWorld InWorld) { return default; }
	public static bool RemoveThisConstraint(UWorld InWorld,UTickableConstraint InTickableConstraint) { return default; }
	public static bool RemoveConstraint(UWorld InWorld,int InIndex) { return default; }
}
