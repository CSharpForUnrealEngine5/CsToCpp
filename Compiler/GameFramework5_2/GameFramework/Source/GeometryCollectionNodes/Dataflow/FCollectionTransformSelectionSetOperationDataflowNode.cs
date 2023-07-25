#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
///<summary>Runs boolean operation on TransformSelections</summary>
public partial struct FCollectionTransformSelectionSetOperationDataflowNode {
// CollectionTransformSelectionSetOperationDataflowNode
	public ESetOperationEnum Operation;
	public FDataflowTransformSelection TransformSelectionA;
	public FDataflowTransformSelection TransformSelectionB;
	public FDataflowTransformSelection TransformSelection;
}
