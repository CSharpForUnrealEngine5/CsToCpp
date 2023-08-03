#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows multiple animations to be blended between based on input parameters</summary>
[CppInclude("Animation/BlendSpace.h")]
public partial class UBlendSpace : UAnimationAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Indicates whether any samples have the flag to apply rotation offsets in mesh space</summary>
	public bool bContainsRotationOffsetMeshSpaceSamples;
	///<summary>Input Smoothing parameters for each input axis</summary>
	public FInterpolationParameter InterpolationParam;
	///<summary>Analysis properties for each axis. Note that these can be null. They will be created/set from</summary>
	public UAnalysisProperties AnalysisProperties;
	///<summary>If greater than zero, this is the speed at which the sample weights are allowed to change.</summary>
	public float TargetWeightInterpolationSpeedPerSec;
	///<summary>If set then this eases in/out the sample weight adjustments, using the speed to determine how much smoothing to apply.</summary>
	public bool bTargetWeightInterpolationEaseInOut;
	///<summary>If set then blending is performed in mesh space if there are per-bone sample smoothing overrides.</summary>
	public bool bAllowMeshSpaceBlending;
	///<summary>The default looping behavior of this blend space.</summary>
	public bool bLoop;
	///<summary>Preview Base pose for additive BlendSpace *</summary>
	public UAnimSequence PreviewBasePose;
	///<summary>This is the maximum length of any sample in the blendspace. *</summary>
	public float AnimLength;
	///<summary>The current mode used by the BlendSpace to decide which animation notifies to fire. Valid options are:</summary>
	public ENotifyTriggerMode NotifyTriggerMode;
	///<summary>If true then interpolation is done via a grid at runtime. If false the interpolation uses the triangulation.</summary>
	public bool bInterpolateUsingGrid;
	///<summary>Preferred edge direction when the triangulation has to make an arbitrary choice</summary>
	public EPreferredTriangulationDirection PreferredTriangulationDirection;
	///<summary>There are two ways to use per pone sample smoothing: Blend profiles and manually maintaining the per bone overrides.</summary>
	public EBlendSpacePerBoneBlendMode PerBoneBlendMode;
	///<summary>Per bone sample smoothing settings, which affect the specified bone and all its descendants in the skeleton.</summary>
	public TArray<FPerBoneInterpolation> ManualPerBoneOverrides;
	///<summary>Reference to a blend profile of the corresponding skeleton to be used for per bone smoothing in case the per bone blend mode is set to use a blend profile.</summary>
	public FBlendSpaceBlendProfile PerBoneBlendProfile;
	///<summary>Track index to get marker data from. Samples are tested for the suitability of marker based sync</summary>
	public int SampleIndexWithMarkers;
	///<summary>Sample animation data</summary>
	public TArray<FBlendSample> SampleData;
	///<summary>Grid samples, indexing scheme imposed by subclass</summary>
	public TArray<FEditorElement> GridSamples;
	///<summary>Container for the runtime data, which could be line segments, triangulation or tetrahedrons</summary>
	public FBlendSpaceData BlendSpaceData;
	///<summary>Blend Parameters for each axis. *</summary>
	public FBlendParameter BlendParameters;
	///<summary>If you have input smoothing, this specifies the axis on which to scale the animation playback speed. E.g. for</summary>
	public EBlendSpaceAxis AxisToScaleAnimation;
	///<summary>The order in which to use the dimensions in the data - e.g. [1, 2] means a 2D blend using Y and Z</summary>
	public TArray<int> DimensionIndices;
}
