#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditUVIslandsTool.h")]
public partial class UEditUVIslandsTool : UMeshSurfacePointTool {
// EditUVIslandsTool
	public UExistingMeshMaterialProperties MaterialSettings;
	public UMaterialInstanceDynamic CheckerMaterial;
	public AInternalToolFrameworkActor PreviewMeshActor;
	public UDynamicMeshComponent DynamicMeshComponent;
	public UPolygonSelectionMechanic SelectionMechanic;
	public UCombinedTransformGizmo TransformGizmo;
	public UTransformProxy TransformProxy;
}
