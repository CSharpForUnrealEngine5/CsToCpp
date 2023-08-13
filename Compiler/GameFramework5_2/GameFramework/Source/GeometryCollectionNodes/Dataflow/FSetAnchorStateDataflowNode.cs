namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sets the anchored state on the selected bones in a Collection</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FSetAnchorStateDataflowNode {
	public EAnchorStateEnum AnchorState;
	public bool bSetNotSelectedBonesToOppositeState;
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
}
