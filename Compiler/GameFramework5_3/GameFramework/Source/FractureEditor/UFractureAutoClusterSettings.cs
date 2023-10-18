namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolAutoCluster.h")]
public partial class UFractureAutoClusterSettings : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
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
	///<summary>Choose the number of cluster sites to distribute along the X axis</summary>
	public int ClusterGridWidth;
	///<summary>Choose the number of cluster sites to distribute along the Y axis</summary>
	public int ClusterGridDepth;
	///<summary>Choose the number of cluster sites to distribute along the Z axis</summary>
	public int ClusterGridHeight;
	///<summary>If true, show the cluster grid boundary lines.</summary>
	public bool bShowGridLines;
	///<summary>If a cluster has volume less than this value (in cm) cubed, then the auto-cluster process will attempt to merge it into a neighboring cluster.</summary>
	public float MinimumSize;
	///<summary>For a grid distribution, optionally iteratively recenter the grid points to the center of the cluster geometry (technically: applying K-Means iterations) to balance the shape and distribution of the clusters</summary>
	public int DriftIterations;
	///<summary>If true, bones will only be added to the same cluster if they are physically connected (either directly, or via other bones in the same cluster)</summary>
	public bool bEnforceConnectivity;
	///<summary>If true, make sure the site parameters are matched as close as possible ( bEnforceConnectivity can make the number of site larger than the requested input may produce without it )</summary>
	public bool bEnforceSiteParameters;
	///<summary>If true, prevent the creation of clusters with only a single child, skipping creation of a new cluster in such cases.</summary>
	public bool bAvoidIsolated;
}
