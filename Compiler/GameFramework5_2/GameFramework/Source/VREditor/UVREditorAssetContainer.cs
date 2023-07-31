#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Asset container for VREditor.</summary>
[CppInclude("VREditorAssetContainer.h")]
public partial class UVREditorAssetContainer : UDataAsset {
	///<summary>Sounds</summary>
	public USoundBase DockableWindowCloseSound;
	///<summary>DockableWindowOpenSound</summary>
	public USoundBase DockableWindowOpenSound;
	///<summary>DockableWindowDropSound</summary>
	public USoundBase DockableWindowDropSound;
	///<summary>DockableWindowDragSound</summary>
	public USoundBase DockableWindowDragSound;
	///<summary>DropFromContentBrowserSound</summary>
	public USoundBase DropFromContentBrowserSound;
	///<summary>RadialMenuOpenSound</summary>
	public USoundBase RadialMenuOpenSound;
	///<summary>RadialMenuCloseSound</summary>
	public USoundBase RadialMenuCloseSound;
	///<summary>TeleportSound</summary>
	public USoundBase TeleportSound;
	///<summary>ButtonPressSound</summary>
	public USoundCue ButtonPressSound;
	///<summary>AutoScaleSound</summary>
	public USoundBase AutoScaleSound;
	///<summary>Meshes</summary>
	public UStaticMesh GenericHMDMesh;
	///<summary>PlaneMesh</summary>
	public UStaticMesh PlaneMesh;
	///<summary>CylinderMesh</summary>
	public UStaticMesh CylinderMesh;
	///<summary>LaserPointerStartMesh</summary>
	public UStaticMesh LaserPointerStartMesh;
	///<summary>LaserPointerMesh</summary>
	public UStaticMesh LaserPointerMesh;
	///<summary>LaserPointerEndMesh</summary>
	public UStaticMesh LaserPointerEndMesh;
	///<summary>LaserPointerHoverMesh</summary>
	public UStaticMesh LaserPointerHoverMesh;
	///<summary>VivePreControllerMesh</summary>
	public UStaticMesh VivePreControllerMesh;
	///<summary>OculusControllerMesh</summary>
	public UStaticMesh OculusControllerMesh;
	///<summary>GenericControllerMesh</summary>
	public UStaticMesh GenericControllerMesh;
	///<summary>TeleportRootMesh</summary>
	public UStaticMesh TeleportRootMesh;
	///<summary>WindowMesh</summary>
	public UStaticMesh WindowMesh;
	///<summary>WindowSelectionBarMesh</summary>
	public UStaticMesh WindowSelectionBarMesh;
	///<summary>WindowCloseButtonMesh</summary>
	public UStaticMesh WindowCloseButtonMesh;
	///<summary>RadialMenuMainMesh</summary>
	public UStaticMesh RadialMenuMainMesh;
	///<summary>RadialMenuPointerMesh</summary>
	public UStaticMesh RadialMenuPointerMesh;
	///<summary>PointerCursorMesh</summary>
	public UStaticMesh PointerCursorMesh;
	///<summary>LineSegmentCylinderMesh</summary>
	public UStaticMesh LineSegmentCylinderMesh;
	///<summary>JointSphereMesh</summary>
	public UStaticMesh JointSphereMesh;
	///<summary>DockingButtonMesh</summary>
	public UStaticMesh DockingButtonMesh;
	///<summary>Materials</summary>
	public UMaterialInterface GridMaterial;
	///<summary>LaserPointerMaterial</summary>
	public UMaterialInterface LaserPointerMaterial;
	///<summary>LaserPointerTranslucentMaterial</summary>
	public UMaterialInterface LaserPointerTranslucentMaterial;
	///<summary>WorldMovementPostProcessMaterial</summary>
	public UMaterial WorldMovementPostProcessMaterial;
	///<summary>TextMaterial</summary>
	public UMaterialInterface TextMaterial;
	///<summary>VivePreControllerMaterial</summary>
	public UMaterialInterface VivePreControllerMaterial;
	///<summary>OculusControllerMaterial</summary>
	public UMaterialInterface OculusControllerMaterial;
	///<summary>TeleportMaterial</summary>
	public UMaterialInterface TeleportMaterial;
	///<summary>WindowMaterial</summary>
	public UMaterialInterface WindowMaterial;
	///<summary>WindowTranslucentMaterial</summary>
	public UMaterialInterface WindowTranslucentMaterial;
	///<summary>LineMaterial</summary>
	public UMaterial LineMaterial;
	///<summary>TranslucentTextMaterial</summary>
	public UMaterialInterface TranslucentTextMaterial;
	///<summary>WidgetMaterial</summary>
	public UMaterialInterface WidgetMaterial;
	///<summary>Specific material for camera widgets that operates in linear color space</summary>
	public UMaterialInterface CameraWidgetMaterial;
	///<summary>Fonts</summary>
	public UFont TextFont;
}
