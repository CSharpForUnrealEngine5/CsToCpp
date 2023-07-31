#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selects bones if their Vertices/BoundingBox/Centroid in a sphere</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FCollectionTransformSelectionInSphereDataflowNode {
	public FManagedArrayCollection Collection;
	public FSphere Sphere;
	public FTransform Transform;
	public ESelectSubjectTypeEnum Type;
	public bool bAllVerticesMustContainedInSphere;
	public FDataflowTransformSelection TransformSelection;
}
