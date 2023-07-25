#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VREditorAssetContainer.h")]
///<summary>Asset container for VREditor.</summary>
public partial class UVREditorAssetContainer : UDataAsset {
// VREditorAssetContainer
	public USoundBase DockableWindowCloseSound;
	public USoundBase DockableWindowOpenSound;
	public USoundBase DockableWindowDropSound;
	public USoundBase DockableWindowDragSound;
	public USoundBase DropFromContentBrowserSound;
	public USoundBase RadialMenuOpenSound;
	public USoundBase RadialMenuCloseSound;
	public USoundBase TeleportSound;
	public USoundCue ButtonPressSound;
	public USoundBase AutoScaleSound;
	public UStaticMesh GenericHMDMesh;
	public UStaticMesh PlaneMesh;
	public UStaticMesh CylinderMesh;
	public UStaticMesh LaserPointerStartMesh;
	public UStaticMesh LaserPointerMesh;
	public UStaticMesh LaserPointerEndMesh;
	public UStaticMesh LaserPointerHoverMesh;
	public UStaticMesh VivePreControllerMesh;
	public UStaticMesh OculusControllerMesh;
	public UStaticMesh GenericControllerMesh;
	public UStaticMesh TeleportRootMesh;
	public UStaticMesh WindowMesh;
	public UStaticMesh WindowSelectionBarMesh;
	public UStaticMesh WindowCloseButtonMesh;
	public UStaticMesh RadialMenuMainMesh;
	public UStaticMesh RadialMenuPointerMesh;
	public UStaticMesh PointerCursorMesh;
	public UStaticMesh LineSegmentCylinderMesh;
	public UStaticMesh JointSphereMesh;
	public UStaticMesh DockingButtonMesh;
	public UMaterialInterface GridMaterial;
	public UMaterialInterface LaserPointerMaterial;
	public UMaterialInterface LaserPointerTranslucentMaterial;
	public UMaterial WorldMovementPostProcessMaterial;
	public UMaterialInterface TextMaterial;
	public UMaterialInterface VivePreControllerMaterial;
	public UMaterialInterface OculusControllerMaterial;
	public UMaterialInterface TeleportMaterial;
	public UMaterialInterface WindowMaterial;
	public UMaterialInterface WindowTranslucentMaterial;
	public UMaterial LineMaterial;
	public UMaterialInterface TranslucentTextMaterial;
	public UMaterialInterface WidgetMaterial;
	public UMaterialInterface CameraWidgetMaterial;
	public UFont TextFont;
}
