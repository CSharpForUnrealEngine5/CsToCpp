#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VREditorMode.h")]
///<summary>VR Editor Mode. Extends editor viewports with functionality for VR controls and object manipulation</summary>
public partial class UVREditorMode : UVREditorModeBase {
// VREditorMode
	public void SetGameView(bool bGameView) {}
	public bool IsInGameView() { return default; }
	public float GetWorldScaleFactor() { return default; }
	public AVREditorAvatarActor AvatarActor;
	public UVREditorUISystem UISystem;
	public AVREditorTeleporter TeleportActor;
	public UVREditorAutoScaler AutoScalerSystem;
	public UViewportWorldInteraction WorldInteraction;
	public UVREditorPlacement PlacementSystem;
	public TArray<UVREditorInteractor> Interactors;
	public TSoftObjectPtr<UClass> InteractorClass;
	public TSoftObjectPtr<UClass> TeleporterClass;
	public UVREditorAssetContainer AssetContainer;
}
