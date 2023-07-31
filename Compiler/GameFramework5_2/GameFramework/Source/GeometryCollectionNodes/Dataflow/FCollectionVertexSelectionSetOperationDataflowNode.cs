#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Runs boolean operation on VertexSelections</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FCollectionVertexSelectionSetOperationDataflowNode {
	public ESetOperationEnum Operation;
	public FDataflowVertexSelection VertexSelectionA;
	public FDataflowVertexSelection VertexSelectionB;
	public FDataflowVertexSelection VertexSelection;
}
