#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Noise Field Dataflow node</summary>
[CppInclude("Dataflow/GeometryCollectionFieldNodes.h")]
public partial struct FNoiseFieldDataflowNode {
	public TArray<FVector3f> SamplePositions;
	public FDataflowVertexSelection SampleIndices;
	public float MinRange;
	public float MaxRange;
	public FTransform Transform;
	public TArray<float> FieldFloatResult;
	public TArray<int> FieldRemap;
	public int NumSamplePositions;
}
