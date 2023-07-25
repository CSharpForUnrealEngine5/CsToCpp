#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionConvertOptions.h")]
public partial class UWorldPartitionConvertOptions : UObject {
// WorldPartitionConvertOptions
	public UClass CommandletClass;
	public bool bInPlace;
	public bool bDeleteSourceLevels;
	public bool bGenerateIni;
	public bool bReportOnly;
	public bool bVerbose;
	public bool bSkipStableGUIDValidation;
	public bool bOnlyMergeSubLevels;
	public bool bSaveFoliageTypeToContentFolder;
}
