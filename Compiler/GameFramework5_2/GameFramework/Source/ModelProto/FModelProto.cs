#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Level 0 - FModelProto</summary>
[CppInclude("ModelProto.h")]
public partial struct FModelProto {
	public bool bIsLoaded;
	public long IRVersion;
	public TArray<FOperatorSetIdProto> OpsetImport;
	public string ProducerName;
	public string ProducerVersion;
	public string Domain;
	public long ModelVersion;
	public string DocString;
	public FGraphProto Graph;
	public TArray<FStringStringEntryProto> MetadataProps;
	public TArray<FTrainingInfoProto> TrainingInfo;
}
