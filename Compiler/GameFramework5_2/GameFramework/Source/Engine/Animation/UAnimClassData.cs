#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimClassData.h")]
public partial class UAnimClassData : UObject {
// AnimClassData
	public TArray<FBakedAnimationStateMachine> BakedStateMachines;
	public USkeleton TargetSkeleton;
	public TArray<FAnimNotifyEvent> AnimNotifies;
	public TMap<string,FCachedPoseIndices> OrderedSavedPoseIndicesMap;
	public TArray<FAnimBlueprintFunction> AnimBlueprintFunctions;
	public TArray<FAnimBlueprintFunctionData> AnimBlueprintFunctionData;
	public TArray<object> AnimNodeProperties;
	public TArray<object> LinkedAnimGraphNodeProperties;
	public TArray<object> LinkedAnimLayerNodeProperties;
	public TArray<object> PreUpdateNodeProperties;
	public TArray<object> DynamicResetNodeProperties;
	public TArray<object> StateMachineNodeProperties;
	public TArray<object> InitializationNodeProperties;
	public TMap<string,FGraphAssetPlayerInformation> GraphNameAssetPlayers;
	public TArray<string> SyncGroupNames;
	public TMap<string,FAnimGraphBlendOptions> GraphBlendOptions;
}
