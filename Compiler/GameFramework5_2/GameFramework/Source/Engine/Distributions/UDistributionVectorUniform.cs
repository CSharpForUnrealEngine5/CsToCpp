#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Distributions/DistributionVectorUniform.h")]
public partial class UDistributionVectorUniform : UDistributionVector {
// DistributionVectorUniform
	public FVector Max;
	public FVector Min;
	public bool bLockAxes;
	public EDistributionVectorLockFlags LockedAxes;
	public EDistributionVectorMirrorFlags MirrorFlags;
	public bool bUseExtremes;
}
