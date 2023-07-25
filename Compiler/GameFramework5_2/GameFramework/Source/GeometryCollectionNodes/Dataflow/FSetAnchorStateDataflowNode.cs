#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
///<summary>Sets the anchored state on the selected bones in a Collection</summary>
public partial struct FSetAnchorStateDataflowNode {
// SetAnchorStateDataflowNode
	public EAnchorStateEnum AnchorState;
	public bool bSetNotSelectedBonesToOppositeState;
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
}
