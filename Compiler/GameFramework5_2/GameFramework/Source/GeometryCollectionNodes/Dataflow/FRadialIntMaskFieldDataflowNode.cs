#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionFieldNodes.h")]
///<summary>RadialIntMask Field Dataflow node</summary>
public partial struct FRadialIntMaskFieldDataflowNode {
// RadialIntMaskFieldDataflowNode
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
