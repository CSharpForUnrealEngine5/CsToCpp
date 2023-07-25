#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
///<summary>Gets BoundingBoxes of pieces from a Collection</summary>
public partial struct FGetBoundingBoxesFromCollectionDataflowNode {
// GetBoundingBoxesFromCollectionDataflowNode
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
	public TArray<FBox> BoundingBoxes;
}
