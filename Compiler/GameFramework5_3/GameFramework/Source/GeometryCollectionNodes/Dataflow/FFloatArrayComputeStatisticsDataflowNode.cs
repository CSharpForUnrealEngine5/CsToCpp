namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Computes statistics of a float array</summary>
[CppInclude("Dataflow/GeometryCollectionArrayNodes.h")]
public partial struct FFloatArrayComputeStatisticsDataflowNode {
	public TArray<float> FloatArray;
	public FDataflowTransformSelection TransformSelection;
	public EStatisticsOperationEnum OperationName;
	public float Value;
	public TArray<int> Indices;
}
