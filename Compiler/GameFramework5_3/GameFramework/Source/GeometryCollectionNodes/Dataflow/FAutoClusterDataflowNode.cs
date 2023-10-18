namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Automatically group pieces of a fractured Collection into a specified number of clusters</summary>
[CppInclude("Dataflow/GeometryCollectionClusteringNodes.h")]
public partial struct FAutoClusterDataflowNode {
	public EClusterSizeMethodEnum ClusterSizeMethod;
	public int ClusterSites;
	public float ClusterFraction;
	public float SiteSize;
	public int ClusterGridWidth;
	public int ClusterGridDepth;
	public int ClusterGridHeight;
	public int DriftIterations;
	public float MinimumSize;
	public bool AutoCluster;
	public bool EnforceSiteParameters;
	public bool AvoidIsolated;
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
}
