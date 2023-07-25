#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/MeshSculptToolBase.h")]
///<summary>Base Tool for mesh sculpting tools, provides some shared functionality</summary>
public partial class UMeshSculptToolBase : UMeshSurfacePointTool {
// MeshSculptToolBase
	public USculptBrushProperties BrushProperties;
	public UWorkPlaneProperties GizmoProperties;
	public TMap<int,UMeshSculptBrushOpProps> BrushOpPropSets;
	public TMap<int,UMeshSculptBrushOpProps> SecondaryBrushOpPropSets;
	public UMeshEditingViewProperties ViewProperties;
	public UMaterialInstanceDynamic ActiveOverrideMaterial;
	public UBrushStampIndicator BrushIndicator;
	public bool bIsVolumetricIndicator;
	public UMaterialInstanceDynamic BrushIndicatorMaterial;
	public UPreviewMesh BrushIndicatorMesh;
	public UCombinedTransformGizmo PlaneTransformGizmo;
	public UTransformProxy PlaneTransformProxy;
}
