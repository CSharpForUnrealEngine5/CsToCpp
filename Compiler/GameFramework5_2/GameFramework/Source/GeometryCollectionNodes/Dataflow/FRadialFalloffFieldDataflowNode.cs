#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionFieldNodes.h")]
///<summary>RadialFalloff Field Dataflow node</summary>
public partial struct FRadialFalloffFieldDataflowNode {
// RadialFalloffFieldDataflowNode
	public TArray<FVector3f> SamplePositions;
	public FDataflowVertexSelection SampleIndices;
	public FSphere Sphere;
	public FVector Translation;
	public float Magnitude;
	public float MinRange;
	public float MaxRange;
	public float Default;
	public EDataflowFieldFalloffType FalloffType;
	public TArray<float> FieldFloatResult;
	public TArray<int> FieldRemap;
	public FDataflowVertexSelection FieldSelectionMask;
	public int NumSamplePositions;
}
