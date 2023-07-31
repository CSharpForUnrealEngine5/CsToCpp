#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditUVIslandsTool.h")]
public partial class UEditUVIslandsTool : UMeshSurfacePointTool {
	///<summary>MaterialSettings</summary>
	public UExistingMeshMaterialProperties MaterialSettings;
	///<summary>CheckerMaterial</summary>
	public UMaterialInstanceDynamic CheckerMaterial;
	///<summary>PreviewMeshActor</summary>
	public AInternalToolFrameworkActor PreviewMeshActor;
	///<summary>DynamicMeshComponent</summary>
	public UDynamicMeshComponent DynamicMeshComponent;
	///<summary>SelectionMechanic</summary>
	public UPolygonSelectionMechanic SelectionMechanic;
	///<summary>TransformGizmo</summary>
	public UCombinedTransformGizmo TransformGizmo;
	///<summary>TransformProxy</summary>
	public UTransformProxy TransformProxy;
}
