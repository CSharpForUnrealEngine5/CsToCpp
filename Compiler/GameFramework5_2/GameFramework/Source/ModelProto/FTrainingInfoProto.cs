#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ModelProto.h")]
///<summary>Level 1 - FTrainingInfoProto</summary>
public partial struct FTrainingInfoProto {
// TrainingInfoProto
	public bool bIsLoaded;
	public FGraphProto Initialization;
	public FGraphProto Algorithm;
	public TArray<FStringStringEntryProto> InitializationBinding;
	public TArray<FStringStringEntryProto> UpdateBinding;
}
