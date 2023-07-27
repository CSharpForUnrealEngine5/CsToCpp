#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Distributions/DistributionVectorConstantCurve.h")]
public partial class UDistributionVectorConstantCurve : UDistributionVector {
// DistributionVectorConstantCurve
	public FInterpCurveVector ConstantCurve;
	public bool bLockAxes;
	public EDistributionVectorLockFlags LockedAxes;
}
