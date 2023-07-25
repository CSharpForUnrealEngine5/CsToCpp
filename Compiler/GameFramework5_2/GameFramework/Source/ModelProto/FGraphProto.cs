#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ModelProto.h")]
///<summary>Level 2 - FGraphProto</summary>
public partial struct FGraphProto {
// GraphProto
	public bool bIsLoaded;
	public TArray<FNodeProto> Node;
	public string Name;
	public TArray<FTensorProto> Initializer;
	public TArray<FSparseTensorProto> SparseInitializer;
	public string DocString;
	public TArray<FValueInfoProto> Input;
	public TArray<FValueInfoProto> Output;
	public TArray<FValueInfoProto> ValueInfo;
}
