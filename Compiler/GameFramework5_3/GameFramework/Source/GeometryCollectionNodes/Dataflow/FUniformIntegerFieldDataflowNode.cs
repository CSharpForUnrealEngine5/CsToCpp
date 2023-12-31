namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UniformInteger Field Dataflow node</summary>
[CppInclude("Dataflow/GeometryCollectionFieldNodes.h")]
public partial struct FUniformIntegerFieldDataflowNode {
	public TArray<FVector3f> SamplePositions;
	public FDataflowVertexSelection SampleIndices;
	public int Magnitude;
	public TArray<int> FieldIntResult;
	public TArray<int> FieldRemap;
	public int NumSamplePositions;
}
