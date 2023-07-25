#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
///<summary>Update the proximity (contact) graph for the bones in a Collection</summary>
public partial struct FProximityDataflowNode {
// ProximityDataflowNode
	public EProximityMethodEnum ProximityMethod;
	public float DistanceThreshold;
	public float ContactThreshold;
	public bool bUseAsConnectionGraph;
	public FManagedArrayCollection Collection;
}
