namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint library for altering and analyzing animation / skeletal data</summary>
[CppInclude("AnimationBlueprintLibrary.h")]
public partial class UAnimationBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Retrieves the number of animation frames for the given Animation Sequence</summary>
	public static void GetNumFrames(UAnimSequenceBase AnimationSequenceBase,int NumFrames) {}
	///<summary>Retrieves the number of animation keys for the given Animation Sequence</summary>
	public static void GetNumKeys(UAnimSequenceBase AnimationSequenceBase,int NumKeys) {}
	///<summary>Retrieves the Names of the individual ATracks for the given Animation Sequence</summary>
	public static void GetAnimationTrackNames(UAnimSequenceBase AnimationSequenceBase,TArray<string> TrackNames) {}
	///<summary>Retrieves the Names of the Animation Slots used in the given Montage</summary>
	public static void GetMontageSlotNames(UAnimMontage AnimationMontage,TArray<string> SlotNames) {}
	///<summary>Retrieves the Names of the individual float curves for the given Animation Sequence</summary>
	public static void GetAnimationCurveNames(UAnimSequence AnimationSequence,ERawCurveTrackTypes CurveType,TArray<string> CurveNames) {}
	///<summary>GetRawTrackPositionData</summary>
	public static void GetRawTrackPositionData(UAnimSequenceBase AnimationSequenceBase,string TrackName,TArray<FVector> PositionData) {}
	///<summary>GetRawTrackRotationData</summary>
	public static void GetRawTrackRotationData(UAnimSequenceBase AnimationSequenceBase,string TrackName,TArray<FQuat> RotationData) {}
	///<summary>GetRawTrackScaleData</summary>
	public static void GetRawTrackScaleData(UAnimSequenceBase AnimationSequenceBase,string TrackName,TArray<FVector> ScaleData) {}
	///<summary>GetRawTrackData</summary>
	public static void GetRawTrackData(UAnimSequenceBase AnimationSequenceBase,string TrackName,TArray<FVector> PositionKeys,TArray<FQuat> RotationKeys,TArray<FVector> ScalingKeys) {}
	///<summary>Checks whether or not the given Animation Track Name is contained within the Animation Sequence</summary>
	public static bool IsValidRawAnimationTrackName(UAnimSequenceBase AnimationSequenceBase,string TrackName) { return default; }
	///<summary>Retrieves the Bone Compression Settings for the given Animation Sequence</summary>
	public static void GetBoneCompressionSettings(UAnimSequence AnimationSequence,UAnimBoneCompressionSettings CompressionSettings) {}
	///<summary>Sets the Bone Compression Settings for the given Animation Sequence</summary>
	public static void SetBoneCompressionSettings(UAnimSequence AnimationSequence,UAnimBoneCompressionSettings CompressionSettings) {}
	///<summary>Retrieves the Curve Compression Settings for the given Animation Sequence</summary>
	public static void GetCurveCompressionSettings(UAnimSequence AnimationSequence,UAnimCurveCompressionSettings CompressionSettings) {}
	///<summary>Sets the Curve Compression Settings for the given Animation Sequence</summary>
	public static void SetCurveCompressionSettings(UAnimSequence AnimationSequence,UAnimCurveCompressionSettings CompressionSettings) {}
	///<summary>Retrieves the Additive Animation type for the given Animation Sequence</summary>
	public static void GetAdditiveAnimationType(UAnimSequence AnimationSequence,EAdditiveAnimationType AdditiveAnimationType) {}
	///<summary>Sets the Additive Animation type for the given Animation Sequence</summary>
	public static void SetAdditiveAnimationType(UAnimSequence AnimationSequence,EAdditiveAnimationType AdditiveAnimationType) {}
	///<summary>Retrieves the Additive Base Pose type for the given Animation Sequence</summary>
	public static void GetAdditiveBasePoseType(UAnimSequence AnimationSequence,EAdditiveBasePoseType AdditiveBasePoseType) {}
	///<summary>Sets the Additive Base Pose type for the given Animation Sequence</summary>
	public static void SetAdditiveBasePoseType(UAnimSequence AnimationSequence,EAdditiveBasePoseType AdditiveBasePoseType) {}
	///<summary>Retrieves the Animation Interpolation type for the given Animation Sequence</summary>
	public static void GetAnimationInterpolationType(UAnimSequence AnimationSequence,EAnimInterpolationType InterpolationType) {}
	///<summary>Sets the Animation Interpolation type for the given Animation Sequence</summary>
	public static void SetAnimationInterpolationType(UAnimSequence AnimationSequence,EAnimInterpolationType InterpolationType) {}
	///<summary>Checks whether or not Root Motion is Enabled for the given Animation Sequence</summary>
	public static bool IsRootMotionEnabled(UAnimSequence AnimationSequence) { return default; }
	///<summary>Sets whether or not Root Motion is Enabled for the given Animation Sequence</summary>
	public static void SetRootMotionEnabled(UAnimSequence AnimationSequence,bool bEnabled) {}
	///<summary>Retrieves the Root Motion Lock Type for the given Animation Sequence</summary>
	public static void GetRootMotionLockType(UAnimSequence AnimationSequence,ERootMotionRootLock LockType) {}
	///<summary>Sets the Root Motion Lock Type for the given Animation Sequence</summary>
	public static void SetRootMotionLockType(UAnimSequence AnimationSequence,ERootMotionRootLock RootMotionLockType) {}
	///<summary>Checks whether or not Root Motion locking is Forced for the given Animation Sequence</summary>
	public static bool IsRootMotionLockForced(UAnimSequence AnimationSequence) { return default; }
	///<summary>Sets whether or not Root Motion locking is Forced for the given Animation Sequence</summary>
	public static void SetIsRootMotionLockForced(UAnimSequence AnimationSequence,bool bForced) {}
	///<summary>Retrieves all the Animation Sync Markers for the given Animation Sequence</summary>
	public static void GetAnimationSyncMarkers(UAnimSequence AnimationSequence,TArray<FAnimSyncMarker> Markers) {}
	///<summary>Retrieves all the Unique Names for the Animation Sync Markers contained by the given Animation Sequence</summary>
	public static void GetUniqueMarkerNames(UAnimSequence AnimationSequence,TArray<string> MarkerNames) {}
	///<summary>Adds an Animation Sync Marker to Notify track in the given Animation with the corresponding Marker Name and Time</summary>
	public static void AddAnimationSyncMarker(UAnimSequence AnimationSequence,string MarkerName,float Time,string NotifyTrackName) {}
	///<summary>Checks whether or not the given Marker Name is a valid Animation Sync Marker Name</summary>
	public static bool IsValidAnimationSyncMarkerName(UAnimSequence AnimationSequence,string MarkerName) { return default; }
	///<summary>Removes All Animation Sync Marker found within the Animation Sequence whose name matches MarkerName, and returns the number of removed instances</summary>
	public static int RemoveAnimationSyncMarkersByName(UAnimSequence AnimationSequence,string MarkerName) { return default; }
	///<summary>Removes All Animation Sync Marker found within the Animation Sequence that belong to the specific Notify Track, and returns the number of removed instances</summary>
	public static int RemoveAnimationSyncMarkersByTrack(UAnimSequence AnimationSequence,string NotifyTrackName) { return default; }
	///<summary>Removes All Animation Sync Markers found within the Animation Sequence, and returns the number of removed instances</summary>
	public static void RemoveAllAnimationSyncMarkers(UAnimSequence AnimationSequence) {}
	///<summary>Retrieves all Animation Notify Events found within the given Animation Sequence</summary>
	public static void GetAnimationNotifyEvents(UAnimSequenceBase AnimationSequenceBase,TArray<FAnimNotifyEvent> NotifyEvents) {}
	///<summary>Retrieves all Unique Animation Notify Events found within the given Animation Sequence</summary>
	public static void GetAnimationNotifyEventNames(UAnimSequenceBase AnimationSequenceBase,TArray<string> EventNames) {}
	///<summary>Adds an Animation Notify Event to Notify track in the given Animation with the given Notify creation data</summary>
	public static UAnimNotify AddAnimationNotifyEvent(UAnimSequenceBase AnimationSequenceBase,string NotifyTrackName,float StartTime,UClass NotifyClass) { return default; }
	///<summary>Adds an Animation Notify State Event to Notify track in the given Animation with the given Notify State creation data</summary>
	public static UAnimNotifyState AddAnimationNotifyStateEvent(UAnimSequenceBase AnimationSequenceBase,string NotifyTrackName,float StartTime,float Duration,UClass NotifyStateClass) { return default; }
	///<summary>Adds an the specific Animation Notify to the Animation Sequence (requires Notify&#39;s outer to be the Animation Sequence)</summary>
	public static void AddAnimationNotifyEventObject(UAnimSequenceBase AnimationSequenceBase,float StartTime,UAnimNotify Notify,string NotifyTrackName) {}
	///<summary>Adds an the specific Animation Notify State to the Animation Sequence (requires Notify State&#39;s outer to be the Animation Sequence)</summary>
	public static void AddAnimationNotifyStateEventObject(UAnimSequenceBase AnimationSequenceBase,float StartTime,float Duration,UAnimNotifyState NotifyState,string NotifyTrackName) {}
	///<summary>Removes Animation Notify Events found by Name within the Animation Sequence, and returns the number of removed name instances</summary>
	public static int RemoveAnimationNotifyEventsByName(UAnimSequenceBase AnimationSequenceBase,string NotifyName) { return default; }
	///<summary>Removes Animation Notify Events found by Track within the Animation Sequence, and returns the number of removed name instances</summary>
	public static int RemoveAnimationNotifyEventsByTrack(UAnimSequenceBase AnimationSequenceBase,string NotifyTrackName) { return default; }
	///<summary>Replaces animation notifies in the specified Animation Sequence</summary>
	public static void ReplaceAnimNotifyStates(UAnimSequenceBase AnimationSequenceBase,UClass OldNotifyClass,UClass NewNotifyClass,FOnNotifyStateReplaced OnNotifyStateReplaced) {}
	///<summary>Replaces animation notifies in the specified Animation Sequence</summary>
	public static void ReplaceAnimNotifies(UAnimSequenceBase AnimationSequenceBase,UClass OldNotifyClass,UClass NewNotifyClass,FOnNotifyReplaced OnNotifyReplaced) {}
	///<summary>Copies animation notifies from Src Animation Sequence to Dest. Creates anim notify tracks as necessary. Returns true on success.</summary>
	public static void CopyAnimNotifiesFromSequence(UAnimSequenceBase SourceAnimationSequenceBase,UAnimSequenceBase DestinationAnimationSequenceBase,bool bDeleteExistingNotifies/*=false*/) {}
	///<summary>Retrieves all Unique Animation Notify Track Names found within the given Animation Sequence</summary>
	public static void GetAnimationNotifyTrackNames(UAnimSequenceBase AnimationSequenceBase,TArray<string> TrackNames) {}
	///<summary>Adds an Animation Notify Track to the Animation Sequence</summary>
	public static void AddAnimationNotifyTrack(UAnimSequenceBase AnimationSequenceBase,string NotifyTrackName,FLinearColor TrackColor/*=FLinearColor.White*/) {}
	///<summary>Removes an Animation Notify Track from Animation Sequence by Name</summary>
	public static void RemoveAnimationNotifyTrack(UAnimSequenceBase AnimationSequenceBase,string NotifyTrackName) {}
	///<summary>Removes All Animation Notify Tracks from Animation Sequence</summary>
	public static void RemoveAllAnimationNotifyTracks(UAnimSequenceBase AnimationSequenceBase) {}
	///<summary>Checks whether or not the given Track Name is a valid Animation Notify Track in the Animation Sequence</summary>
	public static bool IsValidAnimNotifyTrackName(UAnimSequenceBase AnimationSequenceBase,string NotifyTrackName) { return default; }
	///<summary>Returns the actual trigger time for a NotifyEvent</summary>
	public static float GetAnimNotifyEventTriggerTime(FAnimNotifyEvent NotifyEvent) { return default; }
	///<summary>Returns the duration for a NotifyEvent, only non-zero for Anim Notify States</summary>
	public static float GetAnimNotifyEventDuration(FAnimNotifyEvent NotifyEvent) { return default; }
	///<summary>Retrieves all Animation Sync Markers for the given Notify Track Name from the given Animation Sequence</summary>
	public static void GetAnimationSyncMarkersForTrack(UAnimSequence AnimationSequence,string NotifyTrackName,TArray<FAnimSyncMarker> Markers) {}
	///<summary>Retrieves all Animation Notify Events for the given Notify Track Name from the given Animation Sequence</summary>
	public static void GetAnimationNotifyEventsForTrack(UAnimSequenceBase AnimationSequenceBase,string NotifyTrackName,TArray<FAnimNotifyEvent> Events) {}
	///<summary>Adds an Animation Curve by Type and Name to the given Animation Sequence</summary>
	public static void AddCurve(UAnimSequence AnimationSequence,string CurveName,ERawCurveTrackTypes CurveType/*=ERawCurveTrackTypes.RCT_Float*/,bool bMetaDataCurve/*=false*/) {}
	///<summary>Removes an Animation Curve by Name from the given Animation Sequence (Raw Animation Curves [Names] may not be removed from the Skeleton)</summary>
	public static void RemoveCurve(UAnimSequence AnimationSequence,string CurveName,bool bRemoveNameFromSkeleton/*=false*/) {}
	///<summary>Removes all Animation Curve Data from the given Animation Sequence (Raw Animation Curves [Names] may not be removed from the Skeleton)</summary>
	public static void RemoveAllCurveData(UAnimSequence AnimationSequence) {}
	///<summary>Adds a Transformation Key to the specified Animation Curve inside of the given Animation Sequence</summary>
	public static void AddTransformationCurveKey(UAnimSequence AnimationSequence,string CurveName,float Time,FTransform Transform) {}
	///<summary>Adds a multiple of Transformation Keys to the specified Animation Curve inside of the given Animation Sequence</summary>
	public static void AddTransformationCurveKeys(UAnimSequence AnimationSequence,string CurveName,TArray<float> Times,TArray<FTransform> Transforms) {}
	///<summary>Adds a Float Key to the specified Animation Curve inside of the given Animation Sequence</summary>
	public static void AddFloatCurveKey(UAnimSequence AnimationSequence,string CurveName,float Time,float Value) {}
	///<summary>Adds a multiple of Float Keys to the specified Animation Curve inside of the given Animation Sequence</summary>
	public static void AddFloatCurveKeys(UAnimSequence AnimationSequence,string CurveName,TArray<float> Times,TArray<float> Values) {}
	///<summary>Adds a Vector Key to the specified Animation Curve inside of the given Animation Sequence</summary>
	public static void AddVectorCurveKey(UAnimSequence AnimationSequence,string CurveName,float Time,FVector Vector) {}
	///<summary>Adds a multiple of Vector Keys to the specified Animation Curve inside of the given Animation Sequence</summary>
	public static void AddVectorCurveKeys(UAnimSequence AnimationSequence,string CurveName,TArray<float> Times,TArray<FVector> Vectors) {}
	///<summary>Checks whether or not the given Bone Name exist on the Skeleton referenced by the given Animation Sequence</summary>
	public static void DoesBoneNameExist(UAnimSequence AnimationSequence,string BoneName,bool bExists) {}
	///<summary>Retrieves, a multiple of, Float Key(s) from the specified Animation Curve inside of the given Animation Sequence</summary>
	public static void GetFloatKeys(UAnimSequence AnimationSequence,string CurveName,TArray<float> Times,TArray<float> Values) {}
	///<summary>Retrieves, a multiple of, Vector Key(s) from the specified Animation Curve inside of the given Animation Sequence</summary>
	public static void GetVectorKeys(UAnimSequence AnimationSequence,string CurveName,TArray<float> Times,TArray<FVector> Values) {}
	///<summary>Retrieves, a multiple of, Transformation Key(s) from the specified Animation Curve inside of the given Animation Sequence</summary>
	public static void GetTransformationKeys(UAnimSequence AnimationSequence,string CurveName,TArray<float> Times,TArray<FTransform> Values) {}
	///<summary>Ensures that any curve names that do not exist on the NewSkeleton are added to it, in which case the SmartName on the actual curve itself will also be updated</summary>
	public static void CopyAnimationCurveNamesToSkeleton(USkeleton OldSkeleton,USkeleton NewSkeleton,UAnimSequenceBase SequenceBase,ERawCurveTrackTypes CurveType) {}
	///<summary>Removes an Animation Curve by Name from the given Animation Sequence (Raw Animation Curves [Names] may not be removed from the Skeleton)</summary>
	public static void RemoveBoneAnimation(UAnimSequence AnimationSequence,string BoneName,bool bIncludeChildren/*=true*/,bool bFinalize/*=true*/) {}
	///<summary>Removes all Animation Bone Track Data from the given Animation Sequence</summary>
	public static void RemoveAllBoneAnimation(UAnimSequence AnimationSequence) {}
	///<summary>FinalizeBoneAnimation</summary>
	public static void FinalizeBoneAnimation(UAnimSequence AnimationSequence) {}
	///<summary>Checks whether or not the given Curve Name exist on the Skeleton referenced by the given Animation Sequence</summary>
	public static bool DoesCurveExist(UAnimSequence AnimationSequence,string CurveName,ERawCurveTrackTypes CurveType) { return default; }
	///<summary>Creates and Adds an instance of the specified MetaData Class to the given Animation Asset</summary>
	public static void AddMetaData(UAnimationAsset AnimationAsset,UClass MetaDataClass,UAnimMetaData MetaDataInstance) {}
	///<summary>Adds an instance of the specified MetaData Class to the given Animation Asset (requires MetaDataObject&#39;s outer to be the Animation Asset)</summary>
	public static void AddMetaDataObject(UAnimationAsset AnimationAsset,UAnimMetaData MetaDataObject) {}
	///<summary>Removes all Meta Data from the given Animation Asset</summary>
	public static void RemoveAllMetaData(UAnimationAsset AnimationAsset) {}
	///<summary>Removes the specified Meta Data Instance from the given Animation Asset</summary>
	public static void RemoveMetaData(UAnimationAsset AnimationAsset,UAnimMetaData MetaDataObject) {}
	///<summary>Removes all Meta Data Instance of the specified Class from the given Animation Asset</summary>
	public static void RemoveMetaDataOfClass(UAnimationAsset AnimationAsset,UClass MetaDataClass) {}
	///<summary>Retrieves all Meta Data Instances from the given Animation Asset</summary>
	public static void GetMetaData(UAnimationAsset AnimationAsset,TArray<UAnimMetaData> MetaData) {}
	///<summary>Retrieves all Meta Data Instances from the given Animation Asset</summary>
	public static void GetMetaDataOfClass(UAnimationAsset AnimationAsset,UClass MetaDataClass,TArray<UAnimMetaData> MetaDataOfClass) {}
	///<summary>Checks whether or not the given Animation Asset contains Meta Data Instance of the specified Meta Data Class</summary>
	public static bool ContainsMetaDataOfClass(UAnimationAsset AnimationAsset,UClass MetaDataClass) { return default; }
	///<summary>GetBonePoseForTime</summary>
	public static void GetBonePoseForTime(UAnimSequenceBase AnimationSequenceBase,string BoneName,float Time,bool bExtractRootMotion,FTransform Pose) {}
	///<summary>GetBonePoseForFrame</summary>
	public static void GetBonePoseForFrame(UAnimSequenceBase AnimationSequenceBase,string BoneName,int Frame,bool bExtractRootMotion,FTransform Pose) {}
	///<summary>GetBonePosesForTime</summary>
	public static void GetBonePosesForTime(UAnimSequenceBase AnimationSequenceBase,TArray<string> BoneNames,float Time,bool bExtractRootMotion,TArray<FTransform> Poses,USkeletalMesh PreviewMesh/*=nullptr*/) {}
	///<summary>GetBonePosesForFrame</summary>
	public static void GetBonePosesForFrame(UAnimSequenceBase AnimationSequenceBase,TArray<string> BoneNames,int Frame,bool bExtractRootMotion,TArray<FTransform> Poses,USkeletalMesh PreviewMesh/*=nullptr*/) {}
	///<summary>Adds a Virtual Bone between the Source and Target Bones to the given Animation Sequence</summary>
	public static void AddVirtualBone(UAnimSequence AnimationSequence,string SourceBoneName,string TargetBoneName,string VirtualBoneName) {}
	///<summary>Removes a Virtual Bone with the specified Bone Name from the given Animation Sequence</summary>
	public static void RemoveVirtualBone(UAnimSequence AnimationSequence,string VirtualBoneName) {}
	///<summary>Removes Virtual Bones with the specified Bone Names from the given Animation Sequence</summary>
	public static void RemoveVirtualBones(UAnimSequence AnimationSequence,TArray<string> VirtualBoneNames) {}
	///<summary>Removes all Virtual Bones from the given Animation Sequence</summary>
	public static void RemoveAllVirtualBones(UAnimSequence AnimationSequence) {}
	///<summary>Retrieves the Length of the given Animation Sequence</summary>
	public static void GetSequenceLength(UAnimSequenceBase AnimationSequenceBase,float Length) {}
	///<summary>Retrieves the (Play) Rate Scale of the given Animation Sequence</summary>
	public static void GetRateScale(UAnimSequenceBase AnimationSequenceBase,float RateScale) {}
	///<summary>Sets the (Play) Rate Scale for the given Animation Sequence</summary>
	public static void SetRateScale(UAnimSequenceBase AnimationSequenceBase,float RateScale) {}
	///<summary>Retrieves the Frame Index at the specified Time Value for the given Animation Sequence</summary>
	public static void GetFrameAtTime(UAnimSequenceBase AnimationSequenceBase,float Time,int Frame) {}
	///<summary>Retrieves the Time Value at the specified Frame Indexfor the given Animation Sequence</summary>
	public static void GetTimeAtFrame(UAnimSequenceBase AnimationSequenceBase,int Frame,float Time) {}
	///<summary>Checks whether or not the given Time Value lies within the given Animation Sequence&#39;s Length</summary>
	public static void IsValidTime(UAnimSequenceBase AnimationSequenceBase,float Time,bool IsValid) {}
	///<summary>Evaluates timecode attributes (e.g. &quot;TCFrame&quot;, &quot;TCSecond&quot;, etc.) of the root bone and returns the resulting qualified frame time.</summary>
	public static bool EvaluateRootBoneTimecodeAttributesAtTime(UAnimSequenceBase AnimationSequenceBase,float EvalTime,FQualifiedFrameTime OutQualifiedFrameTime) { return default; }
	///<summary>Evaluates the subframe timecode attribute (e.g. &quot;TCSubframe&quot;) of the root bone and returns the resulting value.</summary>
	public static bool EvaluateRootBoneTimecodeSubframeAttributeAtTime(UAnimSequenceBase AnimationSequenceBase,float EvalTime,float OutSubframe) { return default; }
	///<summary>Finds the Bone Path from the given Bone to the Root Bone</summary>
	public static void FindBonePathToRoot(UAnimSequenceBase AnimationSequenceBase,string BoneName,TArray<string> BonePath) {}
	///<summary>Returns all Animation Graphs contained by the provided Animation Blueprint</summary>
	public static void GetAnimationGraphs(UAnimBlueprint AnimationBlueprint,TArray<UAnimationGraph> AnimationGraphs) {}
	///<summary>Returns all Animation Graph Nodes of the provided Node Class contained by the Animation Blueprint</summary>
	public static void GetNodesOfClass(UAnimBlueprint AnimationBlueprint,UClass NodeClass,TArray<UAnimGraphNode_Base> GraphNodes,bool bIncludeChildClasses/*=true*/) {}
	///<summary>Adds an Animation Asset override for the provided AnimationBlueprint, replacing any instance of Target with Override</summary>
	public static void AddNodeAssetOverride(UAnimBlueprint AnimBlueprint,UAnimationAsset Target,UAnimationAsset Override,bool bPrintAppliedOverrides/*=false*/) {}
}
