namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionFieldNodes.h")]
public partial struct FSumScalarFieldDataflowNode {
	public TArray<float> FieldFloatLeft;
	public TArray<int> FieldRemapLeft;
	public TArray<float> FieldFloatRight;
	public TArray<int> FieldRemapRight;
	public float Magnitude;
	public EDataflowFloatFieldOperationType Operation;
	public bool bSwapInputs;
	public TArray<float> FieldFloatResult;
	public TArray<int> FieldRemap;
}
