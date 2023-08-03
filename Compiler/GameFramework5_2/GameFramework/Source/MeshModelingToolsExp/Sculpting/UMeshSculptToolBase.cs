#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base Tool for mesh sculpting tools, provides some shared functionality</summary>
[CppInclude("Sculpting/MeshSculptToolBase.h")]
public partial class UMeshSculptToolBase : UMeshSurfacePointTool {
	public static UClass StaticClass() {return default;}
	///<summary>Properties that control brush size/etc</summary>
	public USculptBrushProperties BrushProperties;
	///<summary>Properties for 3D workplane / gizmo</summary>
	public UWorkPlaneProperties GizmoProperties;
	///<summary>BrushOpPropSets</summary>
	public TMap<int,UMeshSculptBrushOpProps> BrushOpPropSets;
	///<summary>SecondaryBrushOpPropSets</summary>
	public TMap<int,UMeshSculptBrushOpProps> SecondaryBrushOpPropSets;
	///<summary>ViewProperties</summary>
	public UMeshEditingViewProperties ViewProperties;
	///<summary>ActiveOverrideMaterial</summary>
	public UMaterialInstanceDynamic ActiveOverrideMaterial;
	///<summary>BrushIndicator</summary>
	public UBrushStampIndicator BrushIndicator;
	///<summary>bIsVolumetricIndicator</summary>
	public bool bIsVolumetricIndicator;
	///<summary>BrushIndicatorMaterial</summary>
	public UMaterialInstanceDynamic BrushIndicatorMaterial;
	///<summary>BrushIndicatorMesh</summary>
	public UPreviewMesh BrushIndicatorMesh;
	///<summary>plane gizmo</summary>
	public UCombinedTransformGizmo PlaneTransformGizmo;
	///<summary>PlaneTransformProxy</summary>
	public UTransformProxy PlaneTransformProxy;
}
