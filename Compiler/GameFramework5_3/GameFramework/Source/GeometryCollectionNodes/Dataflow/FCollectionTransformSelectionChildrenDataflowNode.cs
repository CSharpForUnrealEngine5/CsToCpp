namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selects the children of the selected bones</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FCollectionTransformSelectionChildrenDataflowNode {
	public FDataflowTransformSelection TransformSelection;
	public FManagedArrayCollection Collection;
}
