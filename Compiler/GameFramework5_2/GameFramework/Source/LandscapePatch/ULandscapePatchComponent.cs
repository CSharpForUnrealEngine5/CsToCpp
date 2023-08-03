#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for landscape patches: components that can be attached to meshes and moved around to make</summary>
[CppInclude("LandscapePatchComponent.h")]
public partial class ULandscapePatchComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>RequestLandscapeUpdate</summary>
	public  void RequestLandscapeUpdate(bool bInUserTriggeredUpdate/*=false*/) {}
	///<summary>Allows the patch to be disabled, so that it no longer affects the landscape. This can be useful</summary>
	public  void SetIsEnabled(bool bEnabledIn) {}
	///<summary>@return false if the patch is marked as disabled and therefore can&#39;t affect the landscape.</summary>
	public  bool IsEnabled() { return default; }
	///<summary>GetLandscapeHeightmapCoordsToWorld</summary>
	public  FTransform GetLandscapeHeightmapCoordsToWorld() { return default; }
	///<summary>SetLandscape</summary>
	public  void SetLandscape(ALandscape NewLandscape) {}
	///<summary>SetPatchManager</summary>
	public  void SetPatchManager(ALandscapePatchManager NewPatchManager) {}
	///<summary>GetPatchManager</summary>
	public  ALandscapePatchManager GetPatchManager() { return default; }
	///<summary>Move the patch to be the last processed patch in the current patch manager. This is a way to</summary>
	public  void MoveToTop() {}
	///<summary>Landscape</summary>
	public TSoftObjectPtr<ALandscape> Landscape;
	///<summary>PatchManager</summary>
	public TSoftObjectPtr<ALandscapePatchManager> PatchManager;
	///<summary>When false, patch does not affect the landscape. Useful for temporarily disabling the patch.</summary>
	public bool bIsEnabled;
	///<summary>Starts as false and gets set to true in construction, so gets used to set bWasCopy</summary>
	public bool bPropertiesCopiedIndicator;
	///<summary>Used to properly transition to a different manager when editing it via the detail panel.</summary>
	public TSoftObjectPtr<ALandscapePatchManager> PreviousPatchManager;
}
