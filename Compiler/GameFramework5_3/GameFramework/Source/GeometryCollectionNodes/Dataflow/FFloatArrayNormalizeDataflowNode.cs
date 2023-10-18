namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Normalize the selected float data in a FloatArray</summary>
[CppInclude("Dataflow/GeometryCollectionArrayNodes.h")]
public partial struct FFloatArrayNormalizeDataflowNode {
	public TArray<float> InFloatArray;
	public FDataflowVertexSelection Selection;
	public float MinRange;
	public float MaxRange;
	public TArray<float> OutFloatArray;
}
