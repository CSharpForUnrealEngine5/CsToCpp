#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimSequence.h")]
public partial class UAnimSequence : UAnimSequenceBase {
// AnimSequence
	public float ImportFileFramerate;
	public int ImportResampleFramerate;
	public int NumFrames;
	public int NumberOfKeys;
	public FFrameRate SamplingFrameRate;
	public FGuid RawDataGuid;
	public TArray<string> AnimationTrackNames;
	public bool bAllowFrameStripping;
	public float CompressionErrorThresholdScale;
	public UAnimBoneCompressionSettings BoneCompressionSettings;
	public UAnimCurveCompressionSettings CurveCompressionSettings;
	public EAdditiveAnimationType AdditiveAnimType;
	public EAdditiveBasePoseType RefPoseType;
	public int RefFrameIndex;
	public UAnimSequence RefPoseSeq;
	public string RetargetSource;
	public TSoftObjectPtr<USkeletalMesh> RetargetSourceAsset;
	public TArray<FTransform> RetargetSourceAssetReferencePose;
	public EAnimInterpolationType Interpolation;
	public bool bEnableRootMotion;
	public ERootMotionRootLock RootMotionRootLock;
	public bool bForceRootLock;
	public bool bUseNormalizedRootMotionScale;
	public bool bRootMotionSettingsCopiedFromMontage;
	public int CompressCommandletVersion;
	public bool bDoNotOverrideCompression;
	public UAssetImportData AssetImportData;
	public string SourceFilePath_DEPRECATED;
	public string SourceFileTimestamp_DEPRECATED;
	public TArray<FAnimSyncMarker> AuthoredSyncMarkers;
	public  void AddBoneFloatCustomAttribute(string BoneName,string AttributeName,TArray<float> TimeKeys,TArray<float> ValueKeys) {}
	public  void AddBoneIntegerCustomAttribute(string BoneName,string AttributeName,TArray<float> TimeKeys,TArray<int> ValueKeys) {}
	public  void AddBoneStringCustomAttribute(string BoneName,string AttributeName,TArray<float> TimeKeys,TArray<string> ValueKeys) {}
	public  void RemoveCustomAttribute(string BoneName,string AttributeName) {}
	public  void RemoveAllCustomAttributesForBone(string BoneName) {}
	public  void RemoveAllCustomAttributes() {}
	public FFrameRate TargetFrameRate;
	public FPerPlatformFrameRate PlatformTargetFrameRate;
	public int NumberOfSampledKeys;
	public int NumberOfSampledFrames;
	public TArray<FCustomAttributePerBoneData> PerBoneCustomAttributeData;
	public TMap<FAnimationAttributeIdentifier,FAttributeCurve> AttributeCurves;
}
