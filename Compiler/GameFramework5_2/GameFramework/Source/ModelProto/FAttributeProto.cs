namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Level 4 - FAttributeProto</summary>
[CppInclude("ModelProto.h")]
public partial struct FAttributeProto {
	public string Name;
	public string DocString;
	public EAttributeProtoAttributeType Type;
	public float F;
	public long I;
	public string S;
	public FTensorProto T;
	public FSparseTensorProto SparseTensor;
	public TArray<float> Floats;
	public TArray<long> Integers;
	public TArray<string> Strings;
	public TArray<FTensorProto> Tensors;
	public TArray<FSparseTensorProto> SparseTensors;
}
