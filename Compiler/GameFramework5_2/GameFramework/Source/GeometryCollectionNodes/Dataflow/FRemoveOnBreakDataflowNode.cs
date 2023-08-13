namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FRemoveOnBreakDataflowNode {
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
	public bool bEnabledRemoval;
	public FVector2f PostBreakTimer;
	public FVector2f RemovalTimer;
	public bool bClusterCrumbling;
}
