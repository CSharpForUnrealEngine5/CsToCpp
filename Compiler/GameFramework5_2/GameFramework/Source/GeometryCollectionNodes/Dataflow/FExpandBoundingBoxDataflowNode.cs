#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Description for this node</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FExpandBoundingBoxDataflowNode {
	public FBox BoundingBox;
	public FVector Min;
	public FVector Max;
	public FVector Center;
	public FVector HalfExtents;
	public float Volume;
}
