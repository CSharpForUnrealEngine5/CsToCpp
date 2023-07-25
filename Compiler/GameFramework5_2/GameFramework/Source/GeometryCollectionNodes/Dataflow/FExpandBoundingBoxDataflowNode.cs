#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
///<summary>Description for this node</summary>
public partial struct FExpandBoundingBoxDataflowNode {
// ExpandBoundingBoxDataflowNode
	public FBox BoundingBox;
	public FVector Min;
	public FVector Max;
	public FVector Center;
	public FVector HalfExtents;
	public float Volume;
}
