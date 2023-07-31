#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimCurveCompressionCodec_CompressedRichCurve.h")]
public partial class UAnimCurveCompressionCodec_CompressedRichCurve : UAnimCurveCompressionCodec {
	///<summary>Max error allowed when compressing the rich curves</summary>
	public float MaxCurveError;
	///<summary>Whether to use the animation sequence sample rate or an explicit value</summary>
	public bool UseAnimSequenceSampleRate;
	///<summary>Sample rate to use when measuring the curve error</summary>
	public float ErrorSampleRate;
}
