#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Deletes selected bones from Collection. Empty clusters will be eliminated</summary>
[CppInclude("Dataflow/GeometryCollectionEditNodes.h")]
public partial struct FPruneInCollectionDataflowNode {
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
}
