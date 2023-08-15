namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is a set of helper functions to access various parts of the Sequencer and Control Rig API via Python and Blueprints.</summary>
[CppInclude("ConstraintsScripting.h")]
public partial class UConstraintsScriptingLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get the manager of the constraints. This object contains delegates to listen to for when constraints are added,deleted,</summary>
	public static UConstraintsManager GetManager(UWorld InWorld) { return default; }
	///<summary>Create the transformable handle that deals with getting and setting transforms on this scene component</summary>
	public static UTransformableComponentHandle CreateTransformableComponentHandle(UWorld InWorld,USceneComponent InSceneComponent,FName InSocketName) { return default; }
	///<summary>Create the transformable handle that deals with getting and setting transforms on this object</summary>
	public static UTransformableHandle CreateTransformableHandle(UWorld InWorld,UObject InObject,FName InAttachmentName/*=NAME_None*/) { return default; }
	///<summary>Create Constraint based on the specified type.</summary>
	public static UTickableTransformConstraint CreateFromType(UWorld InWorld,ETransformConstraintType InType) { return default; }
	///<summary>Add Constraint to the system using the incoming parent and child handles with the specified type.</summary>
	public static bool AddConstraint(UWorld InWorld,UTransformableHandle InParentHandle,UTransformableHandle InChildHandle,UTickableTransformConstraint InConstraint,bool bMaintainOffset) { return default; }
	///<summary>Get a copy of the constraints in the current world</summary>
	public static TArray<UTickableConstraint> GetConstraintsArray(UWorld InWorld) { return default; }
	///<summary>Remove specified constraint</summary>
	public static bool RemoveThisConstraint(UWorld InWorld,UTickableConstraint InTickableConstraint) { return default; }
	///<summary>Remove constraint at specified index</summary>
	public static bool RemoveConstraint(UWorld InWorld,int InIndex) { return default; }
}
