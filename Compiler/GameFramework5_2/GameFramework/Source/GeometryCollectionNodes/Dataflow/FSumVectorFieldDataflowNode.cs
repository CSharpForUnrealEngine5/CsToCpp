#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionFieldNodes.h")]
public partial struct FSumVectorFieldDataflowNode {
// SumVectorFieldDataflowNode
	public TArray<float> FieldFloat;
	public TArray<int> FieldFloatRemap;
	public TArray<FVector> FieldVectorLeft;
	public TArray<int> FieldRemapLeft;
	public TArray<FVector> FieldVectorRight;
	public TArray<int> FieldRemapRight;
	public float Magnitude;
	public EDataflowVectorFieldOperationType Operation;
	public bool bSwapVectorInputs;
	public TArray<FVector> FieldVectorResult;
	public TArray<int> FieldRemap;
}
