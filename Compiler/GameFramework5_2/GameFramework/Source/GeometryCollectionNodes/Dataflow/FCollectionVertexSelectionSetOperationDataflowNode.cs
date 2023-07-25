#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
///<summary>Runs boolean operation on VertexSelections</summary>
public partial struct FCollectionVertexSelectionSetOperationDataflowNode {
// CollectionVertexSelectionSetOperationDataflowNode
	public ESetOperationEnum Operation;
	public FDataflowVertexSelection VertexSelectionA;
	public FDataflowVertexSelection VertexSelectionB;
	public FDataflowVertexSelection VertexSelection;
}
