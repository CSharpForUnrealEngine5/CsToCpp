#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimCompress_PerTrackCompression.h")]
public partial class UAnimCompress_PerTrackCompression : UAnimCompress_RemoveLinearKeys {
// AnimCompress_PerTrackCompression
	public float MaxZeroingThreshold;
	public float MaxPosDiffBitwise;
	public float MaxAngleDiffBitwise;
	public float MaxScaleDiffBitwise;
	public TArray<byte> AllowedRotationFormats;
	public TArray<byte> AllowedTranslationFormats;
	public TArray<byte> AllowedScaleFormats;
	public bool bResampleAnimation;
	public float ResampledFramerate;
	public int MinKeysForResampling;
	public bool bUseAdaptiveError;
	public bool bUseOverrideForEndEffectors;
	public int TrackHeightBias;
	public float ParentingDivisor;
	public float ParentingDivisorExponent;
	public bool bUseAdaptiveError2;
	public float RotationErrorSourceRatio;
	public float TranslationErrorSourceRatio;
	public float ScaleErrorSourceRatio;
	public float MaxErrorPerTrackRatio;
	public float PerturbationProbeSize;
}
