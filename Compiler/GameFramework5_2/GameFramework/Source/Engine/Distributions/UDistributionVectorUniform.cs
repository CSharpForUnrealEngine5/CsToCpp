#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Distributions/DistributionVectorUniform.h")]
public partial class UDistributionVectorUniform : UDistributionVector {
	public static UClass StaticClass() {return default;}
	///<summary>Upper end of FVector magnitude range.</summary>
	public FVector Max;
	///<summary>Lower end of FVector magnitude range.</summary>
	public FVector Min;
	///<summary>If true, X == Y == Z ie. only one degree of freedom. If false, each axis is picked independently.</summary>
	public bool bLockAxes;
	///<summary>LockedAxes</summary>
	public EDistributionVectorLockFlags LockedAxes;
	///<summary>MirrorFlags</summary>
	public EDistributionVectorMirrorFlags MirrorFlags;
	///<summary>bUseExtremes</summary>
	public bool bUseExtremes;
}
