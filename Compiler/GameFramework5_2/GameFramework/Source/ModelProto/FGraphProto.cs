namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Level 2 - FGraphProto</summary>
[CppInclude("ModelProto.h")]
public partial struct FGraphProto {
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
