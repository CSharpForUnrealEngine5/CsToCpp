#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>WaveScalar Field Dataflow node v2</summary>
[CppInclude("Dataflow/GeometryCollectionFieldNodes.h")]
public partial struct FWaveScalarFieldDataflowNode {
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
