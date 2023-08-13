namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Gets BoundingBoxes of pieces from a Collection</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FGetBoundingBoxesFromCollectionDataflowNode {
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
	public TArray<FBox> BoundingBoxes;
}
