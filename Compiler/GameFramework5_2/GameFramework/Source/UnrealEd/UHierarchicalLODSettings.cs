#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HierarchicalLOD.h")]
public partial class UHierarchicalLODSettings : UDeveloperSettings {
// HierarchicalLODSettings
	public bool bForceSettingsInAllMaps;
	public bool bSaveLODActorsToHLODPackages;
	public TSoftObjectPtr<UClass> DefaultSetup;
	public TArray<FDirectoryPath> DirectoriesForHLODCommandlet;
	public TArray<FFilePath> MapsToBuild;
	public TSoftObjectPtr<UMaterialInterface> BaseMaterial;
}
