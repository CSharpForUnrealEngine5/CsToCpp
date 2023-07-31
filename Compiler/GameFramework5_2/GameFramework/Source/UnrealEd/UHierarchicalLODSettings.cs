#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HierarchicalLOD.h")]
public partial class UHierarchicalLODSettings : UDeveloperSettings {
	///<summary>If enabled will force the project set HLOD level settings to be used across all levels in the project when Building Clusters</summary>
	public bool bForceSettingsInAllMaps;
	///<summary>If enabled, will save LOD actors descriptions in the HLOD packages</summary>
	public bool bSaveLODActorsToHLODPackages;
	///<summary>When set in combination with</summary>
	public TSoftObjectPtr<UClass> DefaultSetup;
	///<summary>DirectoriesForHLODCommandlet</summary>
	public TArray<FDirectoryPath> DirectoriesForHLODCommandlet;
	///<summary>MapsToBuild</summary>
	public TArray<FFilePath> MapsToBuild;
	///<summary>Base material used for creating a Constant Material Instance as the Proxy Material</summary>
	public TSoftObjectPtr<UMaterialInterface> BaseMaterial;
}
