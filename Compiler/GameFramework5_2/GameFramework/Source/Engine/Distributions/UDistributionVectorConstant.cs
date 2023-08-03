#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Distributions/DistributionVectorConstant.h")]
public partial class UDistributionVectorConstant : UDistributionVector {
	public static UClass StaticClass() {return default;}
	///<summary>This FVector will be returned for all input times.</summary>
	public FVector Constant;
	///<summary>If true, X == Y == Z ie. only one degree of freedom. If false, each axis is picked independently.</summary>
	public bool bLockAxes;
	///<summary>LockedAxes</summary>
	public EDistributionVectorLockFlags LockedAxes;
}
