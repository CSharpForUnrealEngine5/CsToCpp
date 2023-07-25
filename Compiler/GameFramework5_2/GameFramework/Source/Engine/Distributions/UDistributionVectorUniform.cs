#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Distributions/DistributionVectorUniform.h")]
public partial class UDistributionVectorUniform : UDistributionVector {
// DistributionVectorUniform
	public FVector Max;
	public FVector Min;
	public bool bLockAxes;
	public byte LockedAxes;
	public byte MirrorFlags;
	public bool bUseExtremes;
}
