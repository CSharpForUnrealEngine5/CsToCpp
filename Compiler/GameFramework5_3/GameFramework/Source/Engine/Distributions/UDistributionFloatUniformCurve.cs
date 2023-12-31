namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Distributions/DistributionFloatUniformCurve.h")]
public partial class UDistributionFloatUniformCurve : UDistributionFloat {
	public static UClass StaticClass() {return default;}
	///<summary>Keyframe data for how output constant varies over time.</summary>
	public FInterpCurveVector2D ConstantCurve;
}
