#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmoothOrientation/MassSmoothOrientationFragments.h")]
public partial struct FMassSmoothOrientationParameters {
	public float EndOfPathDuration;
	public float OrientationSmoothingTime;
	public FMassSmoothOrientationWeights Moving;
	public FMassSmoothOrientationWeights Standing;
}
