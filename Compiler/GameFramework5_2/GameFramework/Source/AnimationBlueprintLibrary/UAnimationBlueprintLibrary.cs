#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationBlueprintLibrary.h")]
///<summary>Blueprint library for altering and analyzing animation / skeletal data</summary>
public partial class UAnimationBlueprintLibrary : UBlueprintFunctionLibrary {
// AnimationBlueprintLibrary
	public void GetNumFrames(UObject AnimationSequenceBase,int NumFrames) {}
	public void GetNumKeys(UObject AnimationSequenceBase,int NumKeys) {}
	public void GetAnimationTrackNames(UObject AnimationSequenceBase,TArray<string> TrackNames) {}
	public void GetMontageSlotNames(UObject AnimationMontage,TArray<string> SlotNames) {}
	public void GetAnimationCurveNames(UObject AnimationSequence,ERawCurveTrackTypes CurveType,TArray<string> CurveNames) {}
	public void GetRawTrackPositionData(UObject AnimationSequenceBase,string TrackName,TArray<FVector> PositionData) {}
	public void GetRawTrackRotationData(UObject AnimationSequenceBase,string TrackName,TArray<FQuat> RotationData) {}
	public void GetRawTrackScaleData(UObject AnimationSequenceBase,string TrackName,TArray<FVector> ScaleData) {}
	public void GetRawTrackData(UObject AnimationSequenceBase,string TrackName,TArray<FVector> PositionKeys,TArray<FQuat> RotationKeys,TArray<FVector> ScalingKeys) {}
	public bool IsValidRawAnimationTrackName(UObject AnimationSequenceBase,string TrackName) { return default; }
	public void GetBoneCompressionSettings(UObject AnimationSequence,UObject CompressionSettings) {}
	public void SetBoneCompressionSettings(UObject AnimationSequence,UObject CompressionSettings) {}
	public void GetCurveCompressionSettings(UObject AnimationSequence,UObject CompressionSettings) {}
	public void SetCurveCompressionSettings(UObject AnimationSequence,UObject CompressionSettings) {}
	public void GetAdditiveAnimationType(UObject AnimationSequence,byte AdditiveAnimationType) {}
	public void SetAdditiveAnimationType(UObject AnimationSequence,byte AdditiveAnimationType) {}
	public void GetAdditiveBasePoseType(UObject AnimationSequence,byte AdditiveBasePoseType) {}
	public void SetAdditiveBasePoseType(UObject AnimationSequence,byte AdditiveBasePoseType) {}
	public void GetAnimationInterpolationType(UObject AnimationSequence,EAnimInterpolationType InterpolationType) {}
	public void SetAnimationInterpolationType(UObject AnimationSequence,EAnimInterpolationType InterpolationType) {}
	public bool IsRootMotionEnabled(UObject AnimationSequence) { return default; }
	public void SetRootMotionEnabled(UObject AnimationSequence,bool bEnabled) {}
	public void GetRootMotionLockType(UObject AnimationSequence,byte LockType) {}
	public void SetRootMotionLockType(UObject AnimationSequence,byte RootMotionLockType) {}
	public bool IsRootMotionLockForced(UObject AnimationSequence) { return default; }
	public void SetIsRootMotionLockForced(UObject AnimationSequence,bool bForced) {}
	public void GetAnimationSyncMarkers(UObject AnimationSequence,TArray<FAnimSyncMarker> Markers) {}
	public void GetUniqueMarkerNames(UObject AnimationSequence,TArray<string> MarkerNames) {}
	public void AddAnimationSyncMarker(UObject AnimationSequence,string MarkerName,float Time,string NotifyTrackName) {}
	public bool IsValidAnimationSyncMarkerName(UObject AnimationSequence,string MarkerName) { return default; }
	public int RemoveAnimationSyncMarkersByName(UObject AnimationSequence,string MarkerName) { return default; }
	public int RemoveAnimationSyncMarkersByTrack(UObject AnimationSequence,string NotifyTrackName) { return default; }
	public void RemoveAllAnimationSyncMarkers(UObject AnimationSequence) {}
	public void GetAnimationNotifyEvents(UObject AnimationSequenceBase,TArray<FAnimNotifyEvent> NotifyEvents) {}
	public void GetAnimationNotifyEventNames(UObject AnimationSequenceBase,TArray<string> EventNames) {}
	public UObject AddAnimationNotifyEvent(UObject AnimationSequenceBase,string NotifyTrackName,float StartTime,UClass NotifyClass) { return default; }
	public UObject AddAnimationNotifyStateEvent(UObject AnimationSequenceBase,string NotifyTrackName,float StartTime,float Duration,UClass NotifyStateClass) { return default; }
	public void AddAnimationNotifyEventObject(UObject AnimationSequenceBase,float StartTime,UObject Notify,string NotifyTrackName) {}
	public void AddAnimationNotifyStateEventObject(UObject AnimationSequenceBase,float StartTime,float Duration,UObject NotifyState,string NotifyTrackName) {}
	public int RemoveAnimationNotifyEventsByName(UObject AnimationSequenceBase,string NotifyName) { return default; }
	public int RemoveAnimationNotifyEventsByTrack(UObject AnimationSequenceBase,string NotifyTrackName) { return default; }
	public void ReplaceAnimNotifyStates(UObject AnimationSequenceBase,UClass OldNotifyClass,UClass NewNotifyClass,FOnNotifyStateReplaced OnNotifyStateReplaced) {}
	public void ReplaceAnimNotifies(UObject AnimationSequenceBase,UClass OldNotifyClass,UClass NewNotifyClass,FOnNotifyReplaced OnNotifyReplaced) {}
	public void CopyAnimNotifiesFromSequence(UObject SourceAnimationSequenceBase,UObject DestinationAnimationSequenceBase,bool bDeleteExistingNotifies/*=false*/) {}
	public void GetAnimationNotifyTrackNames(UObject AnimationSequenceBase,TArray<string> TrackNames) {}
	public void AddAnimationNotifyTrack(UObject AnimationSequenceBase,string NotifyTrackName,FLinearColor TrackColor/*=FLinearColor.White*/) {}
	public void RemoveAnimationNotifyTrack(UObject AnimationSequenceBase,string NotifyTrackName) {}
	public void RemoveAllAnimationNotifyTracks(UObject AnimationSequenceBase) {}
	public bool IsValidAnimNotifyTrackName(UObject AnimationSequenceBase,string NotifyTrackName) { return default; }
	public float GetAnimNotifyEventTriggerTime(FAnimNotifyEvent NotifyEvent) { return default; }
	public float GetAnimNotifyEventDuration(FAnimNotifyEvent NotifyEvent) { return default; }
	public void GetAnimationSyncMarkersForTrack(UObject AnimationSequence,string NotifyTrackName,TArray<FAnimSyncMarker> Markers) {}
	public void GetAnimationNotifyEventsForTrack(UObject AnimationSequenceBase,string NotifyTrackName,TArray<FAnimNotifyEvent> Events) {}
	public void AddCurve(UObject AnimationSequence,string CurveName,ERawCurveTrackTypes CurveType/*=ERawCurveTrackTypes.RCT_Float*/,bool bMetaDataCurve/*=false*/) {}
	public void RemoveCurve(UObject AnimationSequence,string CurveName,bool bRemoveNameFromSkeleton/*=false*/) {}
	public void RemoveAllCurveData(UObject AnimationSequence) {}
	public void AddTransformationCurveKey(UObject AnimationSequence,string CurveName,float Time,FTransform Transform) {}
	public void AddTransformationCurveKeys(UObject AnimationSequence,string CurveName,TArray<float> Times,TArray<FTransform> Transforms) {}
	public void AddFloatCurveKey(UObject AnimationSequence,string CurveName,float Time,float Value) {}
	public void AddFloatCurveKeys(UObject AnimationSequence,string CurveName,TArray<float> Times,TArray<float> Values) {}
	public void AddVectorCurveKey(UObject AnimationSequence,string CurveName,float Time,FVector Vector) {}
	public void AddVectorCurveKeys(UObject AnimationSequence,string CurveName,TArray<float> Times,TArray<FVector> Vectors) {}
	public void DoesBoneNameExist(UObject AnimationSequence,string BoneName,bool bExists) {}
	public void GetFloatKeys(UObject AnimationSequence,string CurveName,TArray<float> Times,TArray<float> Values) {}
	public void GetVectorKeys(UObject AnimationSequence,string CurveName,TArray<float> Times,TArray<FVector> Values) {}
	public void GetTransformationKeys(UObject AnimationSequence,string CurveName,TArray<float> Times,TArray<FTransform> Values) {}
	public void CopyAnimationCurveNamesToSkeleton(UObject OldSkeleton,UObject NewSkeleton,UObject SequenceBase,ERawCurveTrackTypes CurveType) {}
	public void RemoveBoneAnimation(UObject AnimationSequence,string BoneName,bool bIncludeChildren/*=true*/,bool bFinalize/*=true*/) {}
	public void RemoveAllBoneAnimation(UObject AnimationSequence) {}
	public void FinalizeBoneAnimation(UObject AnimationSequence) {}
	public bool DoesCurveExist(UObject AnimationSequence,string CurveName,ERawCurveTrackTypes CurveType) { return default; }
	public void AddMetaData(UObject AnimationAsset,UClass MetaDataClass,UObject MetaDataInstance) {}
	public void AddMetaDataObject(UObject AnimationAsset,UObject MetaDataObject) {}
	public void RemoveAllMetaData(UObject AnimationAsset) {}
	public void RemoveMetaData(UObject AnimationAsset,UObject MetaDataObject) {}
	public void RemoveMetaDataOfClass(UObject AnimationAsset,UClass MetaDataClass) {}
	public void GetMetaData(UObject AnimationAsset,TArray<UObject> MetaData) {}
	public void GetMetaDataOfClass(UObject AnimationAsset,UClass MetaDataClass,TArray<UObject> MetaDataOfClass) {}
	public bool ContainsMetaDataOfClass(UObject AnimationAsset,UClass MetaDataClass) { return default; }
	public void GetBonePoseForTime(UObject AnimationSequenceBase,string BoneName,float Time,bool bExtractRootMotion,FTransform Pose) {}
	public void GetBonePoseForFrame(UObject AnimationSequenceBase,string BoneName,int Frame,bool bExtractRootMotion,FTransform Pose) {}
	public void GetBonePosesForTime(UObject AnimationSequenceBase,TArray<string> BoneNames,float Time,bool bExtractRootMotion,TArray<FTransform> Poses,UObject PreviewMesh/*=nullptr*/) {}
	public void GetBonePosesForFrame(UObject AnimationSequenceBase,TArray<string> BoneNames,int Frame,bool bExtractRootMotion,TArray<FTransform> Poses,UObject PreviewMesh/*=nullptr*/) {}
	public void AddVirtualBone(UObject AnimationSequence,string SourceBoneName,string TargetBoneName,string VirtualBoneName) {}
	public void RemoveVirtualBone(UObject AnimationSequence,string VirtualBoneName) {}
	public void RemoveVirtualBones(UObject AnimationSequence,TArray<string> VirtualBoneNames) {}
	public void RemoveAllVirtualBones(UObject AnimationSequence) {}
	public void GetSequenceLength(UObject AnimationSequenceBase,float Length) {}
	public void GetRateScale(UObject AnimationSequenceBase,float RateScale) {}
	public void SetRateScale(UObject AnimationSequenceBase,float RateScale) {}
	public void GetFrameAtTime(UObject AnimationSequenceBase,float Time,int Frame) {}
	public void GetTimeAtFrame(UObject AnimationSequenceBase,int Frame,float Time) {}
	public void IsValidTime(UObject AnimationSequenceBase,float Time,bool IsValid) {}
	public bool EvaluateRootBoneTimecodeAttributesAtTime(UObject AnimationSequenceBase,float EvalTime,FQualifiedFrameTime OutQualifiedFrameTime) { return default; }
	public bool EvaluateRootBoneTimecodeSubframeAttributeAtTime(UObject AnimationSequenceBase,float EvalTime,float OutSubframe) { return default; }
	public void FindBonePathToRoot(UObject AnimationSequenceBase,string BoneName,TArray<string> BonePath) {}
	public void GetAnimationGraphs(UObject AnimationBlueprint,TArray<UObject> AnimationGraphs) {}
	public void GetNodesOfClass(UObject AnimationBlueprint,UClass NodeClass,TArray<UObject> GraphNodes,bool bIncludeChildClasses/*=true*/) {}
	public void AddNodeAssetOverride(UObject AnimBlueprint,UObject Target,UObject Override,bool bPrintAppliedOverrides/*=false*/) {}
}
