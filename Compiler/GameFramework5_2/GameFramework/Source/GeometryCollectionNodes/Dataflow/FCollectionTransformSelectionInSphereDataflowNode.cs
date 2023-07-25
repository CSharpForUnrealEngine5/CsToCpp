#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
///<summary>Selects bones if their Vertices/BoundingBox/Centroid in a sphere</summary>
public partial struct FCollectionTransformSelectionInSphereDataflowNode {
// CollectionTransformSelectionInSphereDataflowNode
	public FManagedArrayCollection Collection;
	public FSphere Sphere;
	public FTransform Transform;
	public ESelectSubjectTypeEnum Type;
	public bool bAllVerticesMustContainedInSphere;
	public FDataflowTransformSelection TransformSelection;
}
