#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewportInteractionAssetContainer.h")]
///<summary>Asset container for viewport interaction.</summary>
public partial class UViewportInteractionAssetContainer : UDataAsset {
// ViewportInteractionAssetContainer
	public USoundBase GizmoHandleSelectedSound;
	public USoundBase GizmoHandleDropSound;
	public USoundBase SelectionChangeSound;
	public USoundBase SelectionDropSound;
	public USoundBase SelectionStartDragSound;
	public USoundBase GridSnapSound;
	public USoundBase ActorSnapSound;
	public USoundBase UndoSound;
	public USoundBase RedoSound;
	public UStaticMesh GridMesh;
	public UStaticMesh TranslationHandleMesh;
	public UStaticMesh UniformScaleHandleMesh;
	public UStaticMesh ScaleHandleMesh;
	public UStaticMesh PlaneTranslationHandleMesh;
	public UStaticMesh RotationHandleMesh;
	public UStaticMesh RotationHandleSelectedMesh;
	public UStaticMesh StartRotationIndicatorMesh;
	public UStaticMesh CurrentRotationIndicatorMesh;
	public UStaticMesh FreeRotationHandleMesh;
	public UMaterialInterface GridMaterial;
	public UMaterialInterface TransformGizmoMaterial;
	public UMaterialInterface TranslucentTransformGizmoMaterial;
}
