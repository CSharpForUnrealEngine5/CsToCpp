#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolAutoCluster.h")]
public partial class UFractureAutoClusterSettings : UFractureToolSettings {
	///<summary>AutoClusterMode_DEPRECATED</summary>
	public EFractureAutoClusterMode AutoClusterMode_DEPRECATED;
	///<summary>How to choose the size of the clusters to create</summary>
	public EClusterSizeMethod ClusterSizeMethod;
	///<summary>Use a Voronoi diagram with this many Voronoi sites as a guide for deciding cluster boundaries</summary>
	public uint SiteCount;
	///<summary>Choose the number of Voronoi sites used for clustering as a fraction of the number of child bones to process</summary>
	public float SiteCountFraction;
	///<summary>Choose the Edge-Size of the cube used to groups bones under a cluster (in cm).</summary>
	public float SiteSize;
	///<summary>If true, bones will only be added to the same cluster if they are physically connected (either directly, or via other bones in the same cluster)</summary>
	public bool bEnforceConnectivity;
	///<summary>If true, prevent the creation of clusters with only a single child. Either by merging into a neighboring cluster, or not creating the cluster.</summary>
	public bool bAvoidIsolated;
}
