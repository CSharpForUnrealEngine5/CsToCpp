#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionClusteringNodes.h")]
///<summary>Automatically group pieces of a fractured Collection into a specified number of clusters</summary>
public partial struct FAutoClusterDataflowNode {
// AutoClusterDataflowNode
	public EClusterSizeMethodEnum ClusterSizeMethod;
	public int ClusterSites;
	public float ClusterFraction;
	public float SiteSize;
	public bool AutoCluster;
	public bool AvoidIsolated;
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
}
