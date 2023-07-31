#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UBaseCreateFromSelectedTool is a base Tool (must be subclassed)</summary>
[CppInclude("BaseTools/BaseCreateFromSelectedTool.h")]
public partial class UBaseCreateFromSelectedTool : UMultiSelectionMeshEditingTool {
	///<summary>TransformProperties</summary>
	public UTransformInputsToolProperties TransformProperties;
	///<summary>OutputTypeProperties</summary>
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	///<summary>HandleSourcesProperties</summary>
	public UBaseCreateFromSelectedHandleSourceProperties HandleSourcesProperties;
	///<summary>Preview</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
	///<summary>TransformProxies</summary>
	public TArray<UTransformProxy> TransformProxies;
	///<summary>TransformGizmos</summary>
	public TArray<UCombinedTransformGizmo> TransformGizmos;
}
