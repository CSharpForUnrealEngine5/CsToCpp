#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionEditNodes.h")]
///<summary>Deletes selected bones from Collection. Empty clusters will be eliminated</summary>
public partial struct FPruneInCollectionDataflowNode {
// PruneInCollectionDataflowNode
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
}
