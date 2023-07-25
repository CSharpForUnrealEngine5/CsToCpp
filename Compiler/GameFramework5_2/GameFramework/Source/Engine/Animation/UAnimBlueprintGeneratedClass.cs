#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimBlueprintGeneratedClass.h")]
public partial class UAnimBlueprintGeneratedClass : UBlueprintGeneratedClass {
// AnimBlueprintGeneratedClass
	public TArray<FBakedAnimationStateMachine> BakedStateMachines;
	public USkeleton TargetSkeleton;
	public TArray<FAnimNotifyEvent> AnimNotifies;
	public TMap<string,FCachedPoseIndices> OrderedSavedPoseIndicesMap;
	public TArray<string> SyncGroupNames;
	public TArray<FExposedValueHandler> EvaluateGraphExposedInputs_DEPRECATED;
	public TMap<string,FGraphAssetPlayerInformation> GraphAssetPlayerInformation;
	public TMap<string,FAnimGraphBlendOptions> GraphBlendOptions;
	public TArray<FAnimNodeData> AnimNodeData;
	public TMap<UScriptStruct,FAnimNodeStructData> NodeTypeMap;
}
