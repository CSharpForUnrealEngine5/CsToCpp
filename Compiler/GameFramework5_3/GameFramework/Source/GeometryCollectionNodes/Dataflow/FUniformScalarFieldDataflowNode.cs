namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UniformScalar Field Dataflow node</summary>
[CppInclude("Dataflow/GeometryCollectionFieldNodes.h")]
public partial struct FUniformScalarFieldDataflowNode {
	public TArray<FVector3f> SamplePositions;
	public FDataflowVertexSelection SampleIndices;
	public float Magnitude;
	public TArray<float> FieldFloatResult;
	public TArray<int> FieldRemap;
	public int NumSamplePositions;
}
