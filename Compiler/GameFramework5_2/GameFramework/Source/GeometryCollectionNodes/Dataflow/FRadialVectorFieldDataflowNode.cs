namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>RadialVector Field Dataflow node</summary>
[CppInclude("Dataflow/GeometryCollectionFieldNodes.h")]
public partial struct FRadialVectorFieldDataflowNode {
	public TArray<FVector3f> SamplePositions;
	public FDataflowVertexSelection SampleIndices;
	public float Magnitude;
	public FVector Position;
	public TArray<FVector> FieldVectorResult;
	public TArray<int> FieldRemap;
	public int NumSamplePositions;
}
