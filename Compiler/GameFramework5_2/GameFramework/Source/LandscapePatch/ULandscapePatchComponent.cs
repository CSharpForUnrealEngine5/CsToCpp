#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapePatchComponent.h")]
///<summary>Base class for landscape patches: components that can be attached to meshes and moved around to make</summary>
public partial class ULandscapePatchComponent : USceneComponent {
// LandscapePatchComponent
	public  void RequestLandscapeUpdate(bool bInUserTriggeredUpdate/*=false*/) {}
	public  void SetIsEnabled(bool bEnabledIn) {}
	public  bool IsEnabled() { return default; }
	public  FTransform GetLandscapeHeightmapCoordsToWorld() { return default; }
	public  void SetLandscape(ALandscape NewLandscape) {}
	public  void SetPatchManager(ALandscapePatchManager NewPatchManager) {}
	public  ALandscapePatchManager GetPatchManager() { return default; }
	public  void MoveToTop() {}
	public TSoftObjectPtr<ALandscape> Landscape;
	public TSoftObjectPtr<ALandscapePatchManager> PatchManager;
	public bool bIsEnabled;
	public bool bPropertiesCopiedIndicator;
	public TSoftObjectPtr<ALandscapePatchManager> PreviousPatchManager;
}
