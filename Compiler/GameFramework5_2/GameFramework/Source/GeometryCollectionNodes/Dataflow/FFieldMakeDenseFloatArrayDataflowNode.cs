#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionFieldNodes.h")]
///<summary>Converts a sparse FloatArray (a selected subset of the whole incoming array) into a dense FloatArray</summary>
public partial struct FFieldMakeDenseFloatArrayDataflowNode {
// FieldMakeDenseFloatArrayDataflowNode
	public TArray<float> FieldFloatInput;
	public TArray<int> FieldRemap;
	public int NumSamplePositions;
	public float Default;
	public TArray<float> FieldFloatResult;
}
