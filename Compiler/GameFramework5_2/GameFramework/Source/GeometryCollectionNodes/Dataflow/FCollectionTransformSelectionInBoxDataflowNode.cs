#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
///<summary>Selects bones if their Vertices/BoundingBox/Centroid in a box</summary>
public partial struct FCollectionTransformSelectionInBoxDataflowNode {
// CollectionTransformSelectionInBoxDataflowNode
	public FManagedArrayCollection Collection;
	public FBox Box;
	public FTransform Transform;
	public ESelectSubjectTypeEnum Type;
	public bool bAllVerticesMustContainedInBox;
	public FDataflowTransformSelection TransformSelection;
}
