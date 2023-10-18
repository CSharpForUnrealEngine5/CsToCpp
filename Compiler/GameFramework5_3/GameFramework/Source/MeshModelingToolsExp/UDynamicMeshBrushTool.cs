namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UDynamicMeshBrushTool is a base class that specializes UBaseBrushTool</summary>
[CppInclude("DynamicMeshBrushTool.h")]
public partial class UDynamicMeshBrushTool : UBaseBrushTool {
	public static UClass StaticClass() {return default;}
	///<summary>PreviewMesh</summary>
	public UPreviewMesh PreviewMesh;
}
