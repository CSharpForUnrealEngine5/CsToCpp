#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Distributions/DistributionVectorUniformCurve.h")]
public partial class UDistributionVectorUniformCurve : UDistributionVector {
	public static UClass StaticClass() {return default;}
	///<summary>Keyframe data for how output constant varies over time.</summary>
	public FInterpCurveTwoVectors ConstantCurve;
	///<summary>If true, X == Y == Z ie. only one degree of freedom. If false, each axis is picked independently.</summary>
	public bool bLockAxes1;
	///<summary>bLockAxes2</summary>
	public bool bLockAxes2;
	///<summary>LockedAxes</summary>
	public EDistributionVectorLockFlags LockedAxes;
	///<summary>MirrorFlags</summary>
	public EDistributionVectorMirrorFlags MirrorFlags;
	///<summary>bUseExtremes</summary>
	public bool bUseExtremes;
}
