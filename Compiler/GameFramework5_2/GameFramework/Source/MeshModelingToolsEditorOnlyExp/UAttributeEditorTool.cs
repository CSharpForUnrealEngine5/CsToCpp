#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AttributeEditorTool.h")]
///<summary>Mesh Attribute Editor Tool</summary>
public partial class UAttributeEditorTool : UMultiSelectionMeshEditingTool {
// AttributeEditorTool
	public UAttributeEditorNormalsActions NormalsActions;
	public UAttributeEditorUVActions UVActions;
	public UAttributeEditorLightmapUVActions LightmapUVActions;
	public UAttributeEditorAttribProperties AttributeProps;
	public UAttributeEditorNewAttributeActions NewAttributeProps;
	public UAttributeEditorModifyAttributeActions ModifyAttributeProps;
	public UAttributeEditorCopyAttributeActions CopyAttributeProps;
}
