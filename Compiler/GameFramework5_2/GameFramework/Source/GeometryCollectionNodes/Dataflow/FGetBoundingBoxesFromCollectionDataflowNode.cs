#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Gets BoundingBoxes of pieces from a Collection</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FGetBoundingBoxesFromCollectionDataflowNode {
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
	public TArray<FBox> BoundingBoxes;
}
