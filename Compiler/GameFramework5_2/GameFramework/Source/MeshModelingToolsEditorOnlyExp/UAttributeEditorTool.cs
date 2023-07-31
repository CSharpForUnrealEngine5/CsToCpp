#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mesh Attribute Editor Tool</summary>
[CppInclude("AttributeEditorTool.h")]
public partial class UAttributeEditorTool : UMultiSelectionMeshEditingTool {
	///<summary>NormalsActions</summary>
	public UAttributeEditorNormalsActions NormalsActions;
	///<summary>UVActions</summary>
	public UAttributeEditorUVActions UVActions;
	///<summary>LightmapUVActions</summary>
	public UAttributeEditorLightmapUVActions LightmapUVActions;
	///<summary>AttributeProps</summary>
	public UAttributeEditorAttribProperties AttributeProps;
	///<summary>NewAttributeProps</summary>
	public UAttributeEditorNewAttributeActions NewAttributeProps;
	///<summary>ModifyAttributeProps</summary>
	public UAttributeEditorModifyAttributeActions ModifyAttributeProps;
	///<summary>CopyAttributeProps</summary>
	public UAttributeEditorCopyAttributeActions CopyAttributeProps;
}
