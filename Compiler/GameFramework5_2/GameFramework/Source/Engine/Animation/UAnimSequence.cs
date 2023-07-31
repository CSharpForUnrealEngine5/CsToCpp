#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimSequence.h")]
public partial class UAnimSequence : UAnimSequenceBase {
	///<summary>The DCC framerate of the imported file. UI information only, unit are Hz</summary>
	public float ImportFileFramerate;
	///<summary>The resample framerate that was computed during import. UI information only, unit are Hz</summary>
	public int ImportResampleFramerate;
	///<summary>NumFrames</summary>
	public int NumFrames;
	///<summary>NumberOfKeys</summary>
	public int NumberOfKeys;
	///<summary>SamplingFrameRate</summary>
	public FFrameRate SamplingFrameRate;
	///<summary>RawDataGuid</summary>
	public FGuid RawDataGuid;
	///<summary>AnimationTrackNames</summary>
	public TArray<string> AnimationTrackNames;
	///<summary>Allow frame stripping to be performed on this animation if the platform requests it</summary>
	public bool bAllowFrameStripping;
	///<summary>Set a scale for error threshold on compression. This is useful if the animation will</summary>
	public float CompressionErrorThresholdScale;
	///<summary>The bone compression settings used to compress bones in this sequence.</summary>
	public UAnimBoneCompressionSettings BoneCompressionSettings;
	///<summary>The curve compression settings used to compress curves in this sequence.</summary>
	public UAnimCurveCompressionSettings CurveCompressionSettings;
	///<summary>Additive animation type. *</summary>
	public EAdditiveAnimationType AdditiveAnimType;
	///<summary>Additive refrerence pose type. Refer above enum type</summary>
	public EAdditiveBasePoseType RefPoseType;
	///<summary>Additve reference frame if RefPoseType == AnimFrame *</summary>
	public int RefFrameIndex;
	///<summary>Additive reference animation if it&#39;s relevant - i.e. AnimScaled or AnimFrame *</summary>
	public UAnimSequence RefPoseSeq;
	///<summary>Base pose to use when retargeting</summary>
	public string RetargetSource;
	///<summary>If RetargetSource is set to Default (None), this is asset for the base pose to use when retargeting. Transform data will be saved in RetargetSourceAssetReferencePose.</summary>
	public TSoftObjectPtr<USkeletalMesh> RetargetSourceAsset;
	///<summary>When using RetargetSourceAsset, use the post stored here</summary>
	public TArray<FTransform> RetargetSourceAssetReferencePose;
	///<summary>This defines how values between keys are calculated *</summary>
	public EAnimInterpolationType Interpolation;
	///<summary>If this is on, it will allow extracting of root motion *</summary>
	public bool bEnableRootMotion;
	///<summary>Root Bone will be locked to that position when extracting root motion.*</summary>
	public ERootMotionRootLock RootMotionRootLock;
	///<summary>Force Root Bone Lock even if Root Motion is not enabled</summary>
	public bool bForceRootLock;
	///<summary>If this is on, it will use a normalized scale value for the root motion extracted: FVector(1.0, 1.0, 1.0) *</summary>
	public bool bUseNormalizedRootMotionScale;
	///<summary>Have we copied root motion settings from an owning montage</summary>
	public bool bRootMotionSettingsCopiedFromMontage;
	///<summary>Saved version number with CompressAnimations commandlet. To help with doing it in multiple passes.</summary>
	public int CompressCommandletVersion;
	///<summary>Do not attempt to override compression scheme when running CompressAnimations commandlet.</summary>
	public bool bDoNotOverrideCompression;
	///<summary>Importing data and options used for this mesh</summary>
	public UAssetImportData AssetImportData;
	///<summary>Path to the resource used to construct this skeletal mesh</summary>
	public string SourceFilePath_DEPRECATED;
	///<summary>Date/Time-stamp of the file from the last import</summary>
	public string SourceFileTimestamp_DEPRECATED;
	///<summary>Authored Sync markers</summary>
	public TArray<FAnimSyncMarker> AuthoredSyncMarkers;
	///<summary>AddBoneFloatCustomAttribute</summary>
	public  void AddBoneFloatCustomAttribute(string BoneName,string AttributeName,TArray<float> TimeKeys,TArray<float> ValueKeys) {}
	///<summary>AddBoneIntegerCustomAttribute</summary>
	public  void AddBoneIntegerCustomAttribute(string BoneName,string AttributeName,TArray<float> TimeKeys,TArray<int> ValueKeys) {}
	///<summary>AddBoneStringCustomAttribute</summary>
	public  void AddBoneStringCustomAttribute(string BoneName,string AttributeName,TArray<float> TimeKeys,TArray<string> ValueKeys) {}
	///<summary>RemoveCustomAttribute</summary>
	public  void RemoveCustomAttribute(string BoneName,string AttributeName) {}
	///<summary>RemoveAllCustomAttributesForBone</summary>
	public  void RemoveAllCustomAttributesForBone(string BoneName) {}
	///<summary>RemoveAllCustomAttributes</summary>
	public  void RemoveAllCustomAttributes() {}
	///<summary>TargetFrameRate</summary>
	public FFrameRate TargetFrameRate;
	///<summary>PlatformTargetFrameRate</summary>
	public FPerPlatformFrameRate PlatformTargetFrameRate;
	///<summary>NumberOfSampledKeys</summary>
	public int NumberOfSampledKeys;
	///<summary>NumberOfSampledFrames</summary>
	public int NumberOfSampledFrames;
	///<summary>PerBoneCustomAttributeData</summary>
	public TArray<FCustomAttributePerBoneData> PerBoneCustomAttributeData;
	///<summary>AttributeCurves</summary>
	public TMap<FAnimationAttributeIdentifier,FAttributeCurve> AttributeCurves;
}
