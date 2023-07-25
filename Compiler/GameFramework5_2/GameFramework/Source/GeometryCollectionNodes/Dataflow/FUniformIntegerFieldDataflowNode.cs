#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionFieldNodes.h")]
///<summary>UniformInteger Field Dataflow node</summary>
public partial struct FUniformIntegerFieldDataflowNode {
// UniformIntegerFieldDataflowNode
	public TArray<FVector3f> SamplePositions;
	public FDataflowVertexSelection SampleIndices;
	public int Magnitude;
	public TArray<int> FieldIntResult;
	public TArray<int> FieldRemap;
	public int NumSamplePositions;
}
