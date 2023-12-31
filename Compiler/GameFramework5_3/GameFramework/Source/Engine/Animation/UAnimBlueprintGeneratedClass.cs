namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimBlueprintGeneratedClass.h")]
public partial class UAnimBlueprintGeneratedClass : UBlueprintGeneratedClass {
	public static UClass StaticClass() {return default;}
	///<summary>List of state machines present in this blueprint class</summary>
	public TArray<FBakedAnimationStateMachine> BakedStateMachines;
	///<summary>Target skeleton for this blueprint class</summary>
	public USkeleton TargetSkeleton;
	///<summary>A list of anim notifies that state machines (or anything else) may reference</summary>
	public TArray<FAnimNotifyEvent> AnimNotifies;
	///<summary>Indices for each of the saved pose nodes that require updating, in the order they need to get updates, per layer</summary>
	public TMap<FName,FCachedPoseIndices> OrderedSavedPoseIndicesMap;
	///<summary>Array of sync group names in the order that they are requested during compile</summary>
	public TArray<FName> SyncGroupNames;
	///<summary>Deprecated - moved to FAnimSubsystem_Base</summary>
	public TArray<FExposedValueHandler> EvaluateGraphExposedInputs_DEPRECATED;
	///<summary>Indices for any Asset Player found within a specific (named) Anim Layer Graph, or implemented Anim Interface Graph</summary>
	public TMap<FName,FGraphAssetPlayerInformation> GraphAssetPlayerInformation;
	///<summary>Per layer graph blending options</summary>
	public TMap<FName,FAnimGraphBlendOptions> GraphBlendOptions;
	///<summary>Constant/folded anim node data</summary>
	public TArray<FAnimNodeData> AnimNodeData;
	///<summary>Map from anim node struct to info about that struct (used to accelerate property name lookups)</summary>
	public TMap<UScriptStruct,FAnimNodeStructData> NodeTypeMap;
}
