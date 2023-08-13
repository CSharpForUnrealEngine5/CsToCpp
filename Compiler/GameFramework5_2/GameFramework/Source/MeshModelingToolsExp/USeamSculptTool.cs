namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SeamSculptTool.h")]
public partial class USeamSculptTool : UDynamicMeshBrushTool {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public USeamSculptToolProperties Settings;
	///<summary>PreviewGeom</summary>
	public UPreviewGeometry PreviewGeom;
}
