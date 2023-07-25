#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionFieldNodes.h")]
///<summary>Noise Field Dataflow node</summary>
public partial struct FNoiseFieldDataflowNode {
// NoiseFieldDataflowNode
	public TArray<FVector3f> SamplePositions;
	public FDataflowVertexSelection SampleIndices;
	public float MinRange;
	public float MaxRange;
	public FTransform Transform;
	public TArray<float> FieldFloatResult;
	public TArray<int> FieldRemap;
	public int NumSamplePositions;
}
