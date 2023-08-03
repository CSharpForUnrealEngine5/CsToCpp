#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Distributions/DistributionVectorConstantCurve.h")]
public partial class UDistributionVectorConstantCurve : UDistributionVector {
	public static UClass StaticClass() {return default;}
	///<summary>Keyframe data for each component (X,Y,Z) over time.</summary>
	public FInterpCurveVector ConstantCurve;
	///<summary>If true, X == Y == Z ie. only one degree of freedom. If false, each axis is picked independently.</summary>
	public bool bLockAxes;
	///<summary>LockedAxes</summary>
	public EDistributionVectorLockFlags LockedAxes;
}
