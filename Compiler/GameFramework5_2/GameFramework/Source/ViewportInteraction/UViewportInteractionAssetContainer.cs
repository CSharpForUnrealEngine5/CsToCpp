#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Asset container for viewport interaction.</summary>
[CppInclude("ViewportInteractionAssetContainer.h")]
public partial class UViewportInteractionAssetContainer : UDataAsset {
	///<summary>Sound</summary>
	public USoundBase GizmoHandleSelectedSound;
	///<summary>GizmoHandleDropSound</summary>
	public USoundBase GizmoHandleDropSound;
	///<summary>SelectionChangeSound</summary>
	public USoundBase SelectionChangeSound;
	///<summary>SelectionDropSound</summary>
	public USoundBase SelectionDropSound;
	///<summary>SelectionStartDragSound</summary>
	public USoundBase SelectionStartDragSound;
	///<summary>GridSnapSound</summary>
	public USoundBase GridSnapSound;
	///<summary>ActorSnapSound</summary>
	public USoundBase ActorSnapSound;
	///<summary>UndoSound</summary>
	public USoundBase UndoSound;
	///<summary>RedoSound</summary>
	public USoundBase RedoSound;
	///<summary>Meshes</summary>
	public UStaticMesh GridMesh;
	///<summary>TranslationHandleMesh</summary>
	public UStaticMesh TranslationHandleMesh;
	///<summary>UniformScaleHandleMesh</summary>
	public UStaticMesh UniformScaleHandleMesh;
	///<summary>ScaleHandleMesh</summary>
	public UStaticMesh ScaleHandleMesh;
	///<summary>PlaneTranslationHandleMesh</summary>
	public UStaticMesh PlaneTranslationHandleMesh;
	///<summary>RotationHandleMesh</summary>
	public UStaticMesh RotationHandleMesh;
	///<summary>RotationHandleSelectedMesh</summary>
	public UStaticMesh RotationHandleSelectedMesh;
	///<summary>StartRotationIndicatorMesh</summary>
	public UStaticMesh StartRotationIndicatorMesh;
	///<summary>CurrentRotationIndicatorMesh</summary>
	public UStaticMesh CurrentRotationIndicatorMesh;
	///<summary>FreeRotationHandleMesh</summary>
	public UStaticMesh FreeRotationHandleMesh;
	///<summary>Materials</summary>
	public UMaterialInterface GridMaterial;
	///<summary>TransformGizmoMaterial</summary>
	public UMaterialInterface TransformGizmoMaterial;
	///<summary>TranslucentTransformGizmoMaterial</summary>
	public UMaterialInterface TranslucentTransformGizmoMaterial;
}
