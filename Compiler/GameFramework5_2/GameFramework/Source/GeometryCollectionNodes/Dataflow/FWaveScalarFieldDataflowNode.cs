#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionFieldNodes.h")]
///<summary>WaveScalar Field Dataflow node v2</summary>
public partial struct FWaveScalarFieldDataflowNode {
// WaveScalarFieldDataflowNode
	public TArray<FVector3f> SamplePositions;
	public FDataflowVertexSelection SampleIndices;
	public float Magnitude;
	public FVector Position;
	public FVector Translation;
	public float Wavelength;
	public float Period;
	public EDataflowWaveFunctionType FunctionType;
	public EDataflowFieldFalloffType FalloffType;
	public TArray<float> FieldFloatResult;
	public TArray<int> FieldRemap;
	public int NumSamplePositions;
}
