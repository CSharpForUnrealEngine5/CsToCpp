#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Runs boolean operation on TransformSelections</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FCollectionTransformSelectionSetOperationDataflowNode {
	public ESetOperationEnum Operation;
	public FDataflowTransformSelection TransformSelectionA;
	public FDataflowTransformSelection TransformSelectionB;
	public FDataflowTransformSelection TransformSelection;
}
