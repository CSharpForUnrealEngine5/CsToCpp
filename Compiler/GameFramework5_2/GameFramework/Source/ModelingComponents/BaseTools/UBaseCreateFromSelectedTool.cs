#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseTools/BaseCreateFromSelectedTool.h")]
///<summary>UBaseCreateFromSelectedTool is a base Tool (must be subclassed)</summary>
public partial class UBaseCreateFromSelectedTool : UMultiSelectionMeshEditingTool {
// BaseCreateFromSelectedTool
	public UTransformInputsToolProperties TransformProperties;
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	public UBaseCreateFromSelectedHandleSourceProperties HandleSourcesProperties;
	public UMeshOpPreviewWithBackgroundCompute Preview;
	public TArray<UTransformProxy> TransformProxies;
	public TArray<UCombinedTransformGizmo> TransformGizmos;
}
