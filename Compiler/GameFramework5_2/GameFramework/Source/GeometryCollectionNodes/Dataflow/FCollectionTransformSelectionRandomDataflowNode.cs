#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
///<summary>Selects bones randomly in the Collection</summary>
public partial struct FCollectionTransformSelectionRandomDataflowNode {
// CollectionTransformSelectionRandomDataflowNode
	public bool bDeterministic;
	public float RandomSeed;
	public float RandomThreshold;
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
}
