namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UniformVector Field Dataflow node</summary>
[CppInclude("Dataflow/GeometryCollectionFieldNodes.h")]
public partial struct FUniformVectorFieldDataflowNode {
	public TArray<FVector3f> SamplePositions;
	public FDataflowVertexSelection SampleIndices;
	public float Magnitude;
	public FVector Direction;
	public TArray<FVector> FieldVectorResult;
	public TArray<int> FieldRemap;
	public int NumSamplePositions;
}
