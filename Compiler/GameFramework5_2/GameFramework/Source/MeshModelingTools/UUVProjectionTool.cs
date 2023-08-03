#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UV projection tool</summary>
[CppInclude("UVProjectionTool.h")]
public partial class UUVProjectionTool : USingleTargetWithSelectionTool {
	public static UClass StaticClass() {return default;}
	///<summary>UVChannelProperties</summary>
	public UMeshUVChannelProperties UVChannelProperties;
	///<summary>BasicProperties</summary>
	public UUVProjectionToolProperties BasicProperties;
	///<summary>EditActions</summary>
	public UUVProjectionToolEditActions EditActions;
	///<summary>MaterialSettings</summary>
	public UExistingMeshMaterialProperties MaterialSettings;
	///<summary>Preview</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
	///<summary>CheckerMaterial</summary>
	public UMaterialInstanceDynamic CheckerMaterial;
	///<summary>TransformGizmo</summary>
	public UCombinedTransformGizmo TransformGizmo;
	///<summary>TransformProxy</summary>
	public UTransformProxy TransformProxy;
	///<summary>OperatorFactory</summary>
	public UUVProjectionOperatorFactory OperatorFactory;
	///<summary>EdgeRenderer</summary>
	public UPreviewGeometry EdgeRenderer;
	///<summary>ClickToSetPlaneBehavior</summary>
	public USingleClickInputBehavior ClickToSetPlaneBehavior;
}
