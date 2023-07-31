#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a sparse FloatArray (a selected subset of the whole incoming array) into a dense FloatArray</summary>
[CppInclude("Dataflow/GeometryCollectionFieldNodes.h")]
public partial struct FFieldMakeDenseFloatArrayDataflowNode {
	public TArray<float> FieldFloatInput;
	public TArray<int> FieldRemap;
	public int NumSamplePositions;
	public float Default;
	public TArray<float> FieldFloatResult;
}
