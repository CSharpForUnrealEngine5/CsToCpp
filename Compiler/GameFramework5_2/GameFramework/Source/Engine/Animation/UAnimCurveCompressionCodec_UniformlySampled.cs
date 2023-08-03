#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimCurveCompressionCodec_UniformlySampled.h")]
public partial class UAnimCurveCompressionCodec_UniformlySampled : UAnimCurveCompressionCodec {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to use the animation sequence sample rate or an explicit value</summary>
	public bool UseAnimSequenceSampleRate;
	///<summary>Sample rate to use when uniformly sampling</summary>
	public float SampleRate;
}
