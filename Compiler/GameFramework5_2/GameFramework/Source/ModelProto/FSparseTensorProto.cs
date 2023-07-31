#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Level 5 - FSparseTensorProto</summary>
[CppInclude("ModelProto.h")]
public partial struct FSparseTensorProto {
	public FTensorProto Values;
	public FTensorProto Indices;
	public TArray<long> Dimensions;
}
