namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmoothOrientation/MassSmoothOrientationFragments.h")]
public partial struct FMassSmoothOrientationParameters {
	public float EndOfPathDuration;
	public float OrientationSmoothingTime;
	public FMassSmoothOrientationWeights Moving;
	public FMassSmoothOrientationWeights Standing;
}
