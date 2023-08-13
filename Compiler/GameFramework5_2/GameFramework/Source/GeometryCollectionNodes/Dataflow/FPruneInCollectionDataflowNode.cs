namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Deletes selected bones from Collection. Empty clusters will be eliminated</summary>
[CppInclude("Dataflow/GeometryCollectionEditNodes.h")]
public partial struct FPruneInCollectionDataflowNode {
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
}
