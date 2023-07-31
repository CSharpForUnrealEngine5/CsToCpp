#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>RadialFalloff Field Dataflow node</summary>
[CppInclude("Dataflow/GeometryCollectionFieldNodes.h")]
public partial struct FRadialFalloffFieldDataflowNode {
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
