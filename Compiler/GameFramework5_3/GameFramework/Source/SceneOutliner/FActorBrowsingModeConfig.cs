namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorBrowsingModeSettings.h")]
public partial struct FActorBrowsingModeConfig {
	public bool bHideTemporaryActors;
	public bool bShowOnlyActorsInCurrentLevel;
	public bool bShowOnlyActorsInCurrentDataLayers;
	public bool bShowOnlyActorsInCurrentContentBundle;
	public bool bShowOnlySelectedActors;
	public bool bHideActorComponents;
	public bool bHideLevelInstanceHierarchy;
	public bool bHideUnloadedActors;
	public bool bHideEmptyFolders;
	public bool bAlwaysFrameSelection;
}
