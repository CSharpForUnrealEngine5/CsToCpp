#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVProjectionTool.h")]
///<summary>UV projection tool</summary>
public partial class UUVProjectionTool : USingleTargetWithSelectionTool {
// UVProjectionTool
	public UMeshUVChannelProperties UVChannelProperties;
	public UUVProjectionToolProperties BasicProperties;
	public UUVProjectionToolEditActions EditActions;
	public UExistingMeshMaterialProperties MaterialSettings;
	public UMeshOpPreviewWithBackgroundCompute Preview;
	public UMaterialInstanceDynamic CheckerMaterial;
	public UCombinedTransformGizmo TransformGizmo;
	public UTransformProxy TransformProxy;
	public UUVProjectionOperatorFactory OperatorFactory;
	public UPreviewGeometry EdgeRenderer;
	public USingleClickInputBehavior ClickToSetPlaneBehavior;
}
