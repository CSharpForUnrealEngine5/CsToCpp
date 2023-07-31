#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Normalize the selected float data in a FloatArray</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FFloatArrayNormalizeDataflowNode {
	public TArray<float> InFloatArray;
	public FDataflowVertexSelection Selection;
	public float MinRange;
	public float MaxRange;
	public TArray<float> OutFloatArray;
}
