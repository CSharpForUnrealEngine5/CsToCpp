#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SynthComponents/SynthComponentGranulator.h")]
public enum EGranularSynthEnvelopeType {
	Rectangular=0,
	Triangle=1,
	DownwardTriangle=2,
	UpwardTriangle=3,
	ExponentialDecay=4,
	ExponentialIncrease=5,
	Gaussian=6,
	Hanning=7,
	Lanczos=8,
	Cosine=9,
	CosineSquared=10,
	Welch=11,
	Blackman=12,
	BlackmanHarris=13,
	Count=14,
}
