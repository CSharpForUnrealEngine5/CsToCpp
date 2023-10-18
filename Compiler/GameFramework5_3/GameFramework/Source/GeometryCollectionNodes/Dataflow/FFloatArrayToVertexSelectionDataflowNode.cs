namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a TArray&lt;float&gt; to a FDataflowVertexSelection</summary>
[CppInclude("Dataflow/GeometryCollectionArrayNodes.h")]
public partial struct FFloatArrayToVertexSelectionDataflowNode {
	public TArray<float> FloatArray;
	public ECompareOperation1Enum Operation;
	public float Threshold;
	public FDataflowVertexSelection VertexSelection;
}
