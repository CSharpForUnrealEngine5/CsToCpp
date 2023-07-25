#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Distributions/DistributionVectorUniformCurve.h")]
public partial class UDistributionVectorUniformCurve : UDistributionVector {
// DistributionVectorUniformCurve
	public FInterpCurveTwoVectors ConstantCurve;
	public bool bLockAxes1;
	public bool bLockAxes2;
	public byte LockedAxes;
	public byte MirrorFlags;
	public bool bUseExtremes;
}
