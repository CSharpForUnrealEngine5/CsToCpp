namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a TArray&lt;float&gt; to a FDataflowVertexSelection</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FFloatArrayToVertexSelectionDataflowNode {
	public TArray<float> FloatArray;
	public ECompareOperationEnum Operation;
	public float Threshold;
	public FDataflowVertexSelection VertexSelection;
}
