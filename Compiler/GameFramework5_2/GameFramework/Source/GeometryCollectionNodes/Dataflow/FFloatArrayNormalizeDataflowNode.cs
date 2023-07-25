#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
///<summary>Normalize the selected float data in a FloatArray</summary>
public partial struct FFloatArrayNormalizeDataflowNode {
// FloatArrayNormalizeDataflowNode
	public TArray<float> InFloatArray;
	public FDataflowVertexSelection Selection;
	public float MinRange;
	public float MaxRange;
	public TArray<float> OutFloatArray;
}
