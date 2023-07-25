#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolAutoCluster.h")]
public partial class UFractureAutoClusterSettings : UFractureToolSettings {
// FractureAutoClusterSettings
	public EFractureAutoClusterMode AutoClusterMode_DEPRECATED;
	public EClusterSizeMethod ClusterSizeMethod;
	public uint SiteCount;
	public float SiteCountFraction;
	public float SiteSize;
	public bool bEnforceConnectivity;
	public bool bAvoidIsolated;
}
