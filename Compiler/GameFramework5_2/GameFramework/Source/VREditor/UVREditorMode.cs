#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>VR Editor Mode. Extends editor viewports with functionality for VR controls and object manipulation</summary>
[CppInclude("VREditorMode.h")]
public partial class UVREditorMode : UVREditorModeBase {
	public static UClass StaticClass() {return default;}
	///<summary>Display the scene more closely to how it would appear at runtime (as opposed to edit time).</summary>
	public  void SetGameView(bool bGameView) {}
	///<summary>Returns whether game view is currently active.</summary>
	public  bool IsInGameView() { return default; }
	///<summary>Gets the world scale factor, which can be multiplied by a scale vector to convert to room space</summary>
	public  float GetWorldScaleFactor() { return default; }
	///<summary>Actor with components to represent the VR avatar in the world, including motion controller meshes</summary>
	public AVREditorAvatarActor AvatarActor;
	///<summary>VR UI system</summary>
	public UVREditorUISystem UISystem;
	///<summary>Teleporter system</summary>
	public AVREditorTeleporter TeleportActor;
	///<summary>Automatic scale system</summary>
	public UVREditorAutoScaler AutoScalerSystem;
	///<summary>World interaction manager</summary>
	public UViewportWorldInteraction WorldInteraction;
	///<summary>PlacementSystem</summary>
	public UVREditorPlacement PlacementSystem;
	///<summary>Interactors</summary>
	public TArray<UVREditorInteractor> Interactors;
	///<summary>The controller to use when UnrealEd is in VR mode. Use VREditorInteractor get default editor behavior, or select a custom controller for special behavior</summary>
	public TSoftObjectPtr<UClass> InteractorClass;
	///<summary>The teleporter to use when UnrealEd is in VR mode. Use VREditorTeleporter to get default editor behavior, or select a custom teleporter</summary>
	public TSoftObjectPtr<UClass> TeleporterClass;
	///<summary>Container of assets</summary>
	public UVREditorAssetContainer AssetContainer;
}
