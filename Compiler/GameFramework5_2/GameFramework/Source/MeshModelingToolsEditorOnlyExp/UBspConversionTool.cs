#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts BSP brushes to static meshes.</summary>
[CppInclude("BspConversionTool.h")]
public partial class UBspConversionTool : UInteractiveTool {
	///<summary>Settings</summary>
	public UBspConversionToolProperties Settings;
	///<summary>ToolActions</summary>
	public UBspConversionToolActionPropertySet ToolActions;
	///<summary>PreviewMesh</summary>
	public UPreviewMesh PreviewMesh;
}
