#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionEditorPerProjectUserSettings.h")]
public partial class UWorldPartitionEditorPerProjectUserSettings : UObject {
// WorldPartitionEditorPerProjectUserSettings
	public bool bHideEditorDataLayers;
	public bool bHideRuntimeDataLayers;
	public bool bHideDataLayerActors;
	public bool bHideUnloadedActors;
	public bool bShowOnlySelectedActors;
	public bool bHighlightSelectedDataLayers;
	public bool bHideLevelInstanceContent;
	public bool bDisableLoadingOfLastLoadedRegions;
	public bool bBugItGoLoadRegion;
	public bool bShowCellCoords;
	public TMap<TSoftObjectPtr<UWorld>,FWorldPartitionPerWorldSettings> PerWorldEditorSettings;
}
