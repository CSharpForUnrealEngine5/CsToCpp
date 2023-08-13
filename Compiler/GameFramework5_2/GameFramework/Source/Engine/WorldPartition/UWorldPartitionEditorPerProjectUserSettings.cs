namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionEditorPerProjectUserSettings.h")]
public partial class UWorldPartitionEditorPerProjectUserSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>True when the Data Layer Outliner is displaying Editor Data Layers</summary>
	public bool bHideEditorDataLayers;
	///<summary>True when the Data Layer Outliner is displaying Runtime Data Layers</summary>
	public bool bHideRuntimeDataLayers;
	///<summary>True when the Data Layer Outliner is not displaying actors</summary>
	public bool bHideDataLayerActors;
	///<summary>True when the Data Layer Outliner is not displaying unloaded actors</summary>
	public bool bHideUnloadedActors;
	///<summary>True when the Data Layer Outliner is only displaying actors and datalayers for selected actors</summary>
	public bool bShowOnlySelectedActors;
	///<summary>True when the Data Layer Outliner highlights Data Layers containing actors that are currently selected</summary>
	public bool bHighlightSelectedDataLayers;
	///<summary>True when the Data Layer Outliner is not displaying Level Instance content</summary>
	public bool bHideLevelInstanceContent;
	///<summary>bDisableLoadingOfLastLoadedRegions</summary>
	public bool bDisableLoadingOfLastLoadedRegions;
	///<summary>bBugItGoLoadRegion</summary>
	public bool bBugItGoLoadRegion;
	///<summary>bShowCellCoords</summary>
	public bool bShowCellCoords;
	///<summary>PerWorldEditorSettings</summary>
	public TMap<TSoftObjectPtr<UWorld>,FWorldPartitionPerWorldSettings> PerWorldEditorSettings;
}
