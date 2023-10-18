namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selects the parents of the currently selected bones</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FCollectionTransformSelectionParentDataflowNode {
	public FDataflowTransformSelection TransformSelection;
	public FManagedArrayCollection Collection;
}
