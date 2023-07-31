#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>RadialIntMask Field Dataflow node</summary>
[CppInclude("Dataflow/GeometryCollectionFieldNodes.h")]
public partial struct FRadialIntMaskFieldDataflowNode {
	public TArray<FVector3f> SamplePositions;
	public FDataflowVertexSelection SampleIndices;
	public FSphere Sphere;
	public FVector Translation;
	public int InteriorValue;
	public int ExteriorValue;
	public EDataflowSetMaskConditionType SetMaskConditionType;
	public TArray<int> FieldIntResult;
	public TArray<int> FieldRemap;
	public int NumSamplePositions;
}
