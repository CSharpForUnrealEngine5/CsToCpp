#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LocalizationTargetTypes.h")]
public partial struct FLocalizationTargetSettings {
	public string Name;
	public FGuid Guid;
	public ELocalizationTargetConflictStatus ConflictStatus;
	public TArray<FGuid> TargetDependencies;
	public TArray<FFilePath> AdditionalManifestDependencies;
	public TArray<string> RequiredModuleNames;
	public FGatherTextFromTextFilesConfiguration GatherFromTextFiles;
	public FGatherTextFromPackagesConfiguration GatherFromPackages;
	public FGatherTextFromMetaDataConfiguration GatherFromMetaData;
	public FLocalizationExportingSettings ExportSettings;
	public FLocalizationCompilationSettings CompileSettings;
	public FLocalizationImportDialogueSettings ImportDialogueSettings;
	public int NativeCultureIndex;
	public TArray<FCultureStatistics> SupportedCulturesStatistics;
}
