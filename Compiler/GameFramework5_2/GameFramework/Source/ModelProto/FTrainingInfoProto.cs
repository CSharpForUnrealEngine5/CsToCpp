#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Level 1 - FTrainingInfoProto</summary>
[CppInclude("ModelProto.h")]
public partial struct FTrainingInfoProto {
	public bool bIsLoaded;
	public FGraphProto Initialization;
	public FGraphProto Algorithm;
	public TArray<FStringStringEntryProto> InitializationBinding;
	public TArray<FStringStringEntryProto> UpdateBinding;
}
