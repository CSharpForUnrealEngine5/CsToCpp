#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationBlueprintLibrary.h")]
///<summary>Blueprint library for altering and analyzing animation / skeletal data</summary>
public partial class UAnimationBlueprintLibrary : UBlueprintFunctionLibrary {
// AnimationBlueprintLibrary
	public static void GetNumFrames(UAnimSequenceBase AnimationSequenceBase,int NumFrames) {}
	public static void GetNumKeys(UAnimSequenceBase AnimationSequenceBase,int NumKeys) {}
	public static void GetAnimationTrackNames(UAnimSequenceBase AnimationSequenceBase,TArray<string> TrackNames) {}
	public static void GetMontageSlotNames(UAnimMontage AnimationMontage,TArray<string> SlotNames) {}
	public static void GetAnimationCurveNames(UAnimSequence AnimationSequence,ERawCurveTrackTypes CurveType,TArray<string> CurveNames) {}
	public static void GetRawTrackPositionData(UAnimSequenceBase AnimationSequenceBase,string TrackName,TArray<FVector> PositionData) {}
	public static void GetRawTrackRotationData(UAnimSequenceBase AnimationSequenceBase,string TrackName,TArray<FQuat> RotationData) {}
	public static void GetRawTrackScaleData(UAnimSequenceBase AnimationSequenceBase,string TrackName,TArray<FVector> ScaleData) {}
	public static void GetRawTrackData(UAnimSequenceBase AnimationSequenceBase,string TrackName,TArray<FVector> PositionKeys,TArray<FQuat> RotationKeys,TArray<FVector> ScalingKeys) {}
	public static bool IsValidRawAnimationTrackName(UAnimSequenceBase AnimationSequenceBase,string TrackName) { return default; }
	public static void GetBoneCompressionSettings(UAnimSequence AnimationSequence,UAnimBoneCompressionSettings CompressionSettings) {}
	public static void SetBoneCompressionSettings(UAnimSequence AnimationSequence,UAnimBoneCompressionSettings CompressionSettings) {}
	public static void GetCurveCompressionSettings(UAnimSequence AnimationSequence,UAnimCurveCompressionSettings CompressionSettings) {}
	public static void SetCurveCompressionSettings(UAnimSequence AnimationSequence,UAnimCurveCompressionSettings CompressionSettings) {}
	public static void GetAdditiveAnimationType(UAnimSequence AnimationSequence,byte AdditiveAnimationType) {}
	public static void SetAdditiveAnimationType(UAnimSequence AnimationSequence,byte AdditiveAnimationType) {}
	public static void GetAdditiveBasePoseType(UAnimSequence AnimationSequence,byte AdditiveBasePoseType) {}
	public static void SetAdditiveBasePoseType(UAnimSequence AnimationSequence,byte AdditiveBasePoseType) {}
	public static void GetAnimationInterpolationType(UAnimSequence AnimationSequence,EAnimInterpolationType InterpolationType) {}
	public static void SetAnimationInterpolationType(UAnimSequence AnimationSequence,EAnimInterpolationType InterpolationType) {}
	public static bool IsRootMotionEnabled(UAnimSequence AnimationSequence) { return default; }
	public static void SetRootMotionEnabled(UAnimSequence AnimationSequence,bool bEnabled) {}
	public static void GetRootMotionLockType(UAnimSequence AnimationSequence,byte LockType) {}
	public static void SetRootMotionLockType(UAnimSequence AnimationSequence,byte RootMotionLockType) {}
	public static bool IsRootMotionLockForced(UAnimSequence AnimationSequence) { return default; }
	public static void SetIsRootMotionLockForced(UAnimSequence AnimationSequence,bool bForced) {}
	public static void GetAnimationSyncMarkers(UAnimSequence AnimationSequence,TArray<FAnimSyncMarker> Markers) {}
	public static void GetUniqueMarkerNames(UAnimSequence AnimationSequence,TArray<string> MarkerNames) {}
	public static void AddAnimationSyncMarker(UAnimSequence AnimationSequence,string MarkerName,float Time,string NotifyTrackName) {}
	public static bool IsValidAnimationSyncMarkerName(UAnimSequence AnimationSequence,string MarkerName) { return default; }
	public static int RemoveAnimationSyncMarkersByName(UAnimSequence AnimationSequence,string MarkerName) { return default; }
	public static int RemoveAnimationSyncMarkersByTrack(UAnimSequence AnimationSequence,string NotifyTrackName) { return default; }
	public static void RemoveAllAnimationSyncMarkers(UAnimSequence AnimationSequence) {}
	public static void GetAnimationNotifyEvents(UAnimSequenceBase AnimationSequenceBase,TArray<FAnimNotifyEvent> NotifyEvents) {}
	public static void GetAnimationNotifyEventNames(UAnimSequenceBase AnimationSequenceBase,TArray<string> EventNames) {}
	public static UAnimNotify AddAnimationNotifyEvent(UAnimSequenceBase AnimationSequenceBase,string NotifyTrackName,float StartTime,UClass NotifyClass) { return default; }
	public static UAnimNotifyState AddAnimationNotifyStateEvent(UAnimSequenceBase AnimationSequenceBase,string NotifyTrackName,float StartTime,float Duration,UClass NotifyStateClass) { return default; }
	public static void AddAnimationNotifyEventObject(UAnimSequenceBase AnimationSequenceBase,float StartTime,UAnimNotify Notify,string NotifyTrackName) {}
	public static void AddAnimationNotifyStateEventObject(UAnimSequenceBase AnimationSequenceBase,float StartTime,float Duration,UAnimNotifyState NotifyState,string NotifyTrackName) {}
	public static int RemoveAnimationNotifyEventsByName(UAnimSequenceBase AnimationSequenceBase,string NotifyName) { return default; }
	public static int RemoveAnimationNotifyEventsByTrack(UAnimSequenceBase AnimationSequenceBase,string NotifyTrackName) { return default; }
	public static void ReplaceAnimNotifyStates(UAnimSequenceBase AnimationSequenceBase,UClass OldNotifyClass,UClass NewNotifyClass,FOnNotifyStateReplaced OnNotifyStateReplaced) {}
	public static void ReplaceAnimNotifies(UAnimSequenceBase AnimationSequenceBase,UClass OldNotifyClass,UClass NewNotifyClass,FOnNotifyReplaced OnNotifyReplaced) {}
	public static void CopyAnimNotifiesFromSequence(UAnimSequenceBase SourceAnimationSequenceBase,UAnimSequenceBase DestinationAnimationSequenceBase,bool bDeleteExistingNotifies/*=false*/) {}
	public static void GetAnimationNotifyTrackNames(UAnimSequenceBase AnimationSequenceBase,TArray<string> TrackNames) {}
	public static void AddAnimationNotifyTrack(UAnimSequenceBase AnimationSequenceBase,string NotifyTrackName,FLinearColor TrackColor/*=FLinearColor.White*/) {}
	public static void RemoveAnimationNotifyTrack(UAnimSequenceBase AnimationSequenceBase,string NotifyTrackName) {}
	public static void RemoveAllAnimationNotifyTracks(UAnimSequenceBase AnimationSequenceBase) {}
	public static bool IsValidAnimNotifyTrackName(UAnimSequenceBase AnimationSequenceBase,string NotifyTrackName) { return default; }
	public static float GetAnimNotifyEventTriggerTime(FAnimNotifyEvent NotifyEvent) { return default; }
	public static float GetAnimNotifyEventDuration(FAnimNotifyEvent NotifyEvent) { return default; }
	public static void GetAnimationSyncMarkersForTrack(UAnimSequence AnimationSequence,string NotifyTrackName,TArray<FAnimSyncMarker> Markers) {}
	public static void GetAnimationNotifyEventsForTrack(UAnimSequenceBase AnimationSequenceBase,string NotifyTrackName,TArray<FAnimNotifyEvent> Events) {}
	public static void AddCurve(UAnimSequence AnimationSequence,string CurveName,ERawCurveTrackTypes CurveType/*=ERawCurveTrackTypes.RCT_Float*/,bool bMetaDataCurve/*=false*/) {}
	public static void RemoveCurve(UAnimSequence AnimationSequence,string CurveName,bool bRemoveNameFromSkeleton/*=false*/) {}
	public static void RemoveAllCurveData(UAnimSequence AnimationSequence) {}
	public static void AddTransformationCurveKey(UAnimSequence AnimationSequence,string CurveName,float Time,FTransform Transform) {}
	public static void AddTransformationCurveKeys(UAnimSequence AnimationSequence,string CurveName,TArray<float> Times,TArray<FTransform> Transforms) {}
	public static void AddFloatCurveKey(UAnimSequence AnimationSequence,string CurveName,float Time,float Value) {}
	public static void AddFloatCurveKeys(UAnimSequence AnimationSequence,string CurveName,TArray<float> Times,TArray<float> Values) {}
	public static void AddVectorCurveKey(UAnimSequence AnimationSequence,string CurveName,float Time,FVector Vector) {}
	public static void AddVectorCurveKeys(UAnimSequence AnimationSequence,string CurveName,TArray<float> Times,TArray<FVector> Vectors) {}
	public static void DoesBoneNameExist(UAnimSequence AnimationSequence,string BoneName,bool bExists) {}
	public static void GetFloatKeys(UAnimSequence AnimationSequence,string CurveName,TArray<float> Times,TArray<float> Values) {}
	public static void GetVectorKeys(UAnimSequence AnimationSequence,string CurveName,TArray<float> Times,TArray<FVector> Values) {}
	public static void GetTransformationKeys(UAnimSequence AnimationSequence,string CurveName,TArray<float> Times,TArray<FTransform> Values) {}
	public static void CopyAnimationCurveNamesToSkeleton(USkeleton OldSkeleton,USkeleton NewSkeleton,UAnimSequenceBase SequenceBase,ERawCurveTrackTypes CurveType) {}
	public static void RemoveBoneAnimation(UAnimSequence AnimationSequence,string BoneName,bool bIncludeChildren/*=true*/,bool bFinalize/*=true*/) {}
	public static void RemoveAllBoneAnimation(UAnimSequence AnimationSequence) {}
	public static void FinalizeBoneAnimation(UAnimSequence AnimationSequence) {}
	public static bool DoesCurveExist(UAnimSequence AnimationSequence,string CurveName,ERawCurveTrackTypes CurveType) { return default; }
	public static void AddMetaData(UAnimationAsset AnimationAsset,UClass MetaDataClass,UAnimMetaData MetaDataInstance) {}
	public static void AddMetaDataObject(UAnimationAsset AnimationAsset,UAnimMetaData MetaDataObject) {}
	public static void RemoveAllMetaData(UAnimationAsset AnimationAsset) {}
	public static void RemoveMetaData(UAnimationAsset AnimationAsset,UAnimMetaData MetaDataObject) {}
	public static void RemoveMetaDataOfClass(UAnimationAsset AnimationAsset,UClass MetaDataClass) {}
	public static void GetMetaData(UAnimationAsset AnimationAsset,TArray<UAnimMetaData> MetaData) {}
	public static void GetMetaDataOfClass(UAnimationAsset AnimationAsset,UClass MetaDataClass,TArray<UAnimMetaData> MetaDataOfClass) {}
	public static bool ContainsMetaDataOfClass(UAnimationAsset AnimationAsset,UClass MetaDataClass) { return default; }
	public static void GetBonePoseForTime(UAnimSequenceBase AnimationSequenceBase,string BoneName,float Time,bool bExtractRootMotion,FTransform Pose) {}
	public static void GetBonePoseForFrame(UAnimSequenceBase AnimationSequenceBase,string BoneName,int Frame,bool bExtractRootMotion,FTransform Pose) {}
	public static void GetBonePosesForTime(UAnimSequenceBase AnimationSequenceBase,TArray<string> BoneNames,float Time,bool bExtractRootMotion,TArray<FTransform> Poses,USkeletalMesh PreviewMesh/*=nullptr*/) {}
	public static void GetBonePosesForFrame(UAnimSequenceBase AnimationSequenceBase,TArray<string> BoneNames,int Frame,bool bExtractRootMotion,TArray<FTransform> Poses,USkeletalMesh PreviewMesh/*=nullptr*/) {}
	public static void AddVirtualBone(UAnimSequence AnimationSequence,string SourceBoneName,string TargetBoneName,string VirtualBoneName) {}
	public static void RemoveVirtualBone(UAnimSequence AnimationSequence,string VirtualBoneName) {}
	public static void RemoveVirtualBones(UAnimSequence AnimationSequence,TArray<string> VirtualBoneNames) {}
	public static void RemoveAllVirtualBones(UAnimSequence AnimationSequence) {}
	public static void GetSequenceLength(UAnimSequenceBase AnimationSequenceBase,float Length) {}
	public static void GetRateScale(UAnimSequenceBase AnimationSequenceBase,float RateScale) {}
	public static void SetRateScale(UAnimSequenceBase AnimationSequenceBase,float RateScale) {}
	public static void GetFrameAtTime(UAnimSequenceBase AnimationSequenceBase,float Time,int Frame) {}
	public static void GetTimeAtFrame(UAnimSequenceBase AnimationSequenceBase,int Frame,float Time) {}
	public static void IsValidTime(UAnimSequenceBase AnimationSequenceBase,float Time,bool IsValid) {}
	public static bool EvaluateRootBoneTimecodeAttributesAtTime(UAnimSequenceBase AnimationSequenceBase,float EvalTime,FQualifiedFrameTime OutQualifiedFrameTime) { return default; }
	public static bool EvaluateRootBoneTimecodeSubframeAttributeAtTime(UAnimSequenceBase AnimationSequenceBase,float EvalTime,float OutSubframe) { return default; }
	public static void FindBonePathToRoot(UAnimSequenceBase AnimationSequenceBase,string BoneName,TArray<string> BonePath) {}
	public static void GetAnimationGraphs(UAnimBlueprint AnimationBlueprint,TArray<UAnimationGraph> AnimationGraphs) {}
	public static void GetNodesOfClass(UAnimBlueprint AnimationBlueprint,UClass NodeClass,TArray<UAnimGraphNode_Base> GraphNodes,bool bIncludeChildClasses/*=true*/) {}
	public static void AddNodeAssetOverride(UAnimBlueprint AnimBlueprint,UAnimationAsset Target,UAnimationAsset Override,bool bPrintAppliedOverrides/*=false*/) {}
}
