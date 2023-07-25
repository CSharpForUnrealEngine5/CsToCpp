#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/BlendSpace.h")]
///<summary>Allows multiple animations to be blended between based on input parameters</summary>
public partial class UBlendSpace : UAnimationAsset {
// BlendSpace
	public bool bContainsRotationOffsetMeshSpaceSamples;
	public FInterpolationParameter InterpolationParam;
	public UAnalysisProperties AnalysisProperties;
	public float TargetWeightInterpolationSpeedPerSec;
	public bool bTargetWeightInterpolationEaseInOut;
	public bool bAllowMeshSpaceBlending;
	public bool bLoop;
	public UAnimSequence PreviewBasePose;
	public float AnimLength;
	public byte NotifyTriggerMode;
	public bool bInterpolateUsingGrid;
	public EPreferredTriangulationDirection PreferredTriangulationDirection;
	public EBlendSpacePerBoneBlendMode PerBoneBlendMode;
	public TArray<FPerBoneInterpolation> ManualPerBoneOverrides;
	public FBlendSpaceBlendProfile PerBoneBlendProfile;
	public int SampleIndexWithMarkers;
	public TArray<FBlendSample> SampleData;
	public TArray<FEditorElement> GridSamples;
	public FBlendSpaceData BlendSpaceData;
	public FBlendParameter BlendParameters;
	public byte AxisToScaleAnimation;
	public TArray<int> DimensionIndices;
}
