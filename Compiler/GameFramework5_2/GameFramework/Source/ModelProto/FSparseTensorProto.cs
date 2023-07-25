#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ModelProto.h")]
///<summary>Level 5 - FSparseTensorProto</summary>
public partial struct FSparseTensorProto {
// SparseTensorProto
	public FTensorProto Values;
	public FTensorProto Indices;
	public TArray<long> Dimensions;
}
