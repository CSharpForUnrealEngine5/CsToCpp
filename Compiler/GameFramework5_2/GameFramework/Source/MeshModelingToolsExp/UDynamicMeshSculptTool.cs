#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Dynamic Mesh Sculpt Tool Class</summary>
[CppInclude("DynamicMeshSculptTool.h")]
public partial class UDynamicMeshSculptTool : UMeshSurfacePointTool {
	///<summary>Properties that control brush size/etc</summary>
	public UDynamicMeshBrushProperties BrushProperties;
	///<summary>Properties that control sculpting</summary>
	public UDynamicMeshBrushSculptProperties SculptProperties;
	///<summary>SculptMaxBrushProperties</summary>
	public USculptMaxBrushProperties SculptMaxBrushProperties;
	///<summary>KelvinBrushProperties</summary>
	public UKelvinBrushProperties KelvinBrushProperties;
	///<summary>Properties that control dynamic remeshing</summary>
	public UBrushRemeshProperties RemeshProperties;
	///<summary>GizmoProperties</summary>
	public UFixedPlaneBrushProperties GizmoProperties;
	///<summary>ViewProperties</summary>
	public UMeshEditingViewProperties ViewProperties;
	///<summary>SculptToolActions</summary>
	public UDynamicSculptToolActions SculptToolActions;
	///<summary>BrushIndicator</summary>
	public UBrushStampIndicator BrushIndicator;
	///<summary>BrushIndicatorMaterial</summary>
	public UMaterialInstanceDynamic BrushIndicatorMaterial;
	///<summary>BrushIndicatorMesh</summary>
	public UPreviewMesh BrushIndicatorMesh;
	///<summary>DynamicMeshComponent</summary>
	public UOctreeDynamicMeshComponent DynamicMeshComponent;
	///<summary>ActiveOverrideMaterial</summary>
	public UMaterialInstanceDynamic ActiveOverrideMaterial;
	///<summary>plane gizmo</summary>
	public UCombinedTransformGizmo PlaneTransformGizmo;
	///<summary>PlaneTransformProxy</summary>
	public UTransformProxy PlaneTransformProxy;
}
