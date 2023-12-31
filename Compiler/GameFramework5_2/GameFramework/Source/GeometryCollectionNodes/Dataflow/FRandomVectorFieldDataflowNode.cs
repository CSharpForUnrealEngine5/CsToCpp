namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>RandomVector Field Dataflow node</summary>
[CppInclude("Dataflow/GeometryCollectionFieldNodes.h")]
public partial struct FRandomVectorFieldDataflowNode {
	public TArray<FVector3f> SamplePositions;
	public FDataflowVertexSelection SampleIndices;
	public float Magnitude;
	public TArray<FVector> FieldVectorResult;
	public TArray<int> FieldRemap;
	public int NumSamplePositions;
}
