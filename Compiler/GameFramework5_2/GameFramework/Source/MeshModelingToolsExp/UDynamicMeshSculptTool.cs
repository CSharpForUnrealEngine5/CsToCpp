#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DynamicMeshSculptTool.h")]
///<summary>Dynamic Mesh Sculpt Tool Class</summary>
public partial class UDynamicMeshSculptTool : UMeshSurfacePointTool {
// DynamicMeshSculptTool
	public UDynamicMeshBrushProperties BrushProperties;
	public UDynamicMeshBrushSculptProperties SculptProperties;
	public USculptMaxBrushProperties SculptMaxBrushProperties;
	public UKelvinBrushProperties KelvinBrushProperties;
	public UBrushRemeshProperties RemeshProperties;
	public UFixedPlaneBrushProperties GizmoProperties;
	public UMeshEditingViewProperties ViewProperties;
	public UDynamicSculptToolActions SculptToolActions;
	public UBrushStampIndicator BrushIndicator;
	public UMaterialInstanceDynamic BrushIndicatorMaterial;
	public UPreviewMesh BrushIndicatorMesh;
	public UOctreeDynamicMeshComponent DynamicMeshComponent;
	public UMaterialInstanceDynamic ActiveOverrideMaterial;
	public UCombinedTransformGizmo PlaneTransformGizmo;
	public UTransformProxy PlaneTransformProxy;
}
