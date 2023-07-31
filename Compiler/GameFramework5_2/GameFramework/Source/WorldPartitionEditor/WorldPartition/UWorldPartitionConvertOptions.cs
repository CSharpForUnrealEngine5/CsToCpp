#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionConvertOptions.h")]
public partial class UWorldPartitionConvertOptions : UObject {
	///<summary>CommandletClass</summary>
	public UClass CommandletClass;
	///<summary>Wether the conversion should create a new map with a _WP suffix or overwrite the source map</summary>
	public bool bInPlace;
	///<summary>bDeleteSourceLevels</summary>
	public bool bDeleteSourceLevels;
	///<summary>bGenerateIni</summary>
	public bool bGenerateIni;
	///<summary>bReportOnly</summary>
	public bool bReportOnly;
	///<summary>bVerbose</summary>
	public bool bVerbose;
	///<summary>bSkipStableGUIDValidation</summary>
	public bool bSkipStableGUIDValidation;
	///<summary>bOnlyMergeSubLevels</summary>
	public bool bOnlyMergeSubLevels;
	///<summary>bSaveFoliageTypeToContentFolder</summary>
	public bool bSaveFoliageTypeToContentFolder;
}
