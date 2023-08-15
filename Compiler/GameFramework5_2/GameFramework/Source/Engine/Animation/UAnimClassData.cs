namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimClassData.h")]
public partial class UAnimClassData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>List of state machines present in this blueprint class</summary>
	public TArray<FBakedAnimationStateMachine> BakedStateMachines;
	///<summary>Target skeleton for this blueprint class</summary>
	public USkeleton TargetSkeleton;
	///<summary>A list of anim notifies that state machines (or anything else) may reference</summary>
	public TArray<FAnimNotifyEvent> AnimNotifies;
	///<summary>Indices for each of the saved pose nodes that require updating, in the order they need to get updates.</summary>
	public TMap<FName,FCachedPoseIndices> OrderedSavedPoseIndicesMap;
	///<summary>All of the functions that this anim class provides</summary>
	public TArray<FAnimBlueprintFunction> AnimBlueprintFunctions;
	///<summary>Serialized function data, used to patch up transient data in AnimBlueprintFunctions</summary>
	public TArray<FAnimBlueprintFunctionData> AnimBlueprintFunctionData;
	///<summary>The array of anim nodes</summary>
	public TArray<object> AnimNodeProperties;
	///<summary>The array of linked anim graph nodes</summary>
	public TArray<object> LinkedAnimGraphNodeProperties;
	///<summary>The array of linked anim layer nodes</summary>
	public TArray<object> LinkedAnimLayerNodeProperties;
	///<summary>Array of nodes that need a PreUpdate() call</summary>
	public TArray<object> PreUpdateNodeProperties;
	///<summary>Array of nodes that need a DynamicReset() call</summary>
	public TArray<object> DynamicResetNodeProperties;
	///<summary>Array of state machine nodes</summary>
	public TArray<object> StateMachineNodeProperties;
	///<summary>Array of nodes that need an OnInitializeAnimInstance call</summary>
	public TArray<object> InitializationNodeProperties;
	///<summary>Indices for any Asset Player found within a specific (named) Anim Layer Graph, or implemented Anim Interface Graph</summary>
	public TMap<FName,FGraphAssetPlayerInformation> GraphNameAssetPlayers;
	///<summary>Array of sync group names in the order that they are requested during compile</summary>
	public TArray<FName> SyncGroupNames;
	///<summary>Per layer graph blending options</summary>
	public TMap<FName,FAnimGraphBlendOptions> GraphBlendOptions;
}
