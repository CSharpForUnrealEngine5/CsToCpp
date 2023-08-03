#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Distributions/DistributionFloatConstantCurve.h")]
public partial class UDistributionFloatConstantCurve : UDistributionFloat {
	public static UClass StaticClass() {return default;}
	///<summary>Keyframe data for how output constant varies over time.</summary>
	public FInterpCurveFloat ConstantCurve;
}
