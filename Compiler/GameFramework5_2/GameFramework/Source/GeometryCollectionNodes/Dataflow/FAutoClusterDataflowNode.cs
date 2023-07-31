#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Automatically group pieces of a fractured Collection into a specified number of clusters</summary>
[CppInclude("Dataflow/GeometryCollectionClusteringNodes.h")]
public partial struct FAutoClusterDataflowNode {
	public EClusterSizeMethodEnum ClusterSizeMethod;
	public int ClusterSites;
	public float ClusterFraction;
	public float SiteSize;
	public bool AutoCluster;
	public bool AvoidIsolated;
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
}
