namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts BSP brushes to static meshes.</summary>
[CppInclude("BspConversionTool.h")]
public partial class UBspConversionTool : UInteractiveTool {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public UBspConversionToolProperties Settings;
	///<summary>ToolActions</summary>
	public UBspConversionToolActionPropertySet ToolActions;
	///<summary>PreviewMesh</summary>
	public UPreviewMesh PreviewMesh;
}
