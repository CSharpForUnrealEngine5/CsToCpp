#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
///<summary>Converts a TArray<float> to a FDataflowVertexSelection</summary>
public partial struct FFloatArrayToVertexSelectionDataflowNode {
// FloatArrayToVertexSelectionDataflowNode
	public TArray<float> FloatArray;
	public ECompareOperationEnum Operation;
	public float Threshold;
	public FDataflowVertexSelection VertexSelection;
}
