namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimCompress_PerTrackCompression.h")]
public partial class UAnimCompress_PerTrackCompression : UAnimCompress_RemoveLinearKeys {
	public static UClass StaticClass() {return default;}
	///<summary>Maximum threshold to use when replacing a component with zero. Lower values retain more keys, but yield less compression.</summary>
	public float MaxZeroingThreshold;
	///<summary>Maximum position difference to use when testing if an animation key may be removed. Lower values retain more keys, but yield less compression.</summary>
	public float MaxPosDiffBitwise;
	///<summary>Maximum angle difference to use when testing if an animation key may be removed. Lower values retain more keys, but yield less compression.</summary>
	public float MaxAngleDiffBitwise;
	///<summary>Maximum position difference to use when testing if an animation key may be removed. Lower values retain more keys, but yield less compression.</summary>
	public float MaxScaleDiffBitwise;
	///<summary>Which encoding formats is the per-track compressor allowed to try on rotation keys</summary>
	public TArray<AnimationCompressionFormat> AllowedRotationFormats;
	///<summary>Which encoding formats is the per-track compressor allowed to try on translation keys</summary>
	public TArray<AnimationCompressionFormat> AllowedTranslationFormats;
	///<summary>Which encoding formats is the per-track compressor allowed to try on scale keys</summary>
	public TArray<AnimationCompressionFormat> AllowedScaleFormats;
	///<summary>If true, resample the animation to ResampleFramerate frames per second</summary>
	public bool bResampleAnimation;
	///<summary>When bResampleAnimation is true, this defines the desired framerate</summary>
	public float ResampledFramerate;
	///<summary>Animations with fewer keys than MinKeysForResampling will not be resampled.</summary>
	public int MinKeysForResampling;
	///<summary>If true, adjust the error thresholds based on the &#39;height&#39; within the skeleton</summary>
	public bool bUseAdaptiveError;
	///<summary>If true, uses MinEffectorDiff as the threhsold for end effectors</summary>
	public bool bUseOverrideForEndEffectors;
	///<summary>A bias added to the track height before using it to calculate the adaptive error</summary>
	public int TrackHeightBias;
	///<summary>Reduces the error tolerance the further up the tree that a key occurs</summary>
	public float ParentingDivisor;
	///<summary>Reduces the error tolerance the further up the tree that a key occurs</summary>
	public float ParentingDivisorExponent;
	///<summary>If true, the adaptive error system will determine how much error to allow for each track, based on the</summary>
	public bool bUseAdaptiveError2;
	///<summary>This ratio determines how much error in end effector rotation can come from a given track&#39;s rotation error or translation error.</summary>
	public float RotationErrorSourceRatio;
	///<summary>This ratio determines how much error in end effector translation can come from a given track&#39;s rotation error or translation error.</summary>
	public float TranslationErrorSourceRatio;
	///<summary>This ratio determines how much error in end effector scale can come from a given track&#39;s rotation error or scale error.</summary>
	public float ScaleErrorSourceRatio;
	///<summary>A fraction that determines how much of the total error budget can be introduced by any particular track</summary>
	public float MaxErrorPerTrackRatio;
	///<summary>How big of a perturbation should be made when probing error propagation</summary>
	public float PerturbationProbeSize;
}
