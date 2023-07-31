#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selects bones randomly in the Collection</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FCollectionTransformSelectionRandomDataflowNode {
	public bool bDeterministic;
	public float RandomSeed;
	public float RandomThreshold;
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
}
