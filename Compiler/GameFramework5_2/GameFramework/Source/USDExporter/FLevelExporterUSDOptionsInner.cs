namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelExporterUSDOptions.h")]
public partial struct FLevelExporterUSDOptionsInner {
	public bool bSelectionOnly;
	public bool bExportActorFolders;
	public bool bIgnoreSequencerAnimations;
	public bool bExportFoliageOnActorsLayer;
	public FDirectoryPath AssetFolder;
	public FUsdMeshAssetOptions AssetOptions;
	public int LowestLandscapeLOD;
	public int HighestLandscapeLOD;
	public FIntPoint LandscapeBakeResolution;
	public bool bExportSublayers;
	public TSet<string> LevelsToIgnore;
}
