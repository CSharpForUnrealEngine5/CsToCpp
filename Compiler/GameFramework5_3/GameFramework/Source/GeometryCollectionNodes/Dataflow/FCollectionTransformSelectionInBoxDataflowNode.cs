namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selects bones if their Vertices/BoundingBox/Centroid in a box</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FCollectionTransformSelectionInBoxDataflowNode {
	public FManagedArrayCollection Collection;
	public FBox Box;
	public FTransform Transform;
	public ESelectSubjectTypeEnum Type;
	public bool bAllVerticesMustContainedInBox;
	public FDataflowTransformSelection TransformSelection;
}
