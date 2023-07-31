#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Update the proximity (contact) graph for the bones in a Collection</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FProximityDataflowNode {
	public EProximityMethodEnum ProximityMethod;
	public float DistanceThreshold;
	public float ContactThreshold;
	public bool bUseAsConnectionGraph;
	public FManagedArrayCollection Collection;
}
