namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AddPatchTool.h")]
public partial class UAddPatchTool : USingleClickTool {
	public static UClass StaticClass() {return default;}
	///<summary>ShapeSettings</summary>
	public UAddPatchToolProperties ShapeSettings;
	///<summary>MaterialProperties</summary>
	public UNewMeshMaterialProperties MaterialProperties;
	///<summary>PreviewMesh</summary>
	public UPreviewMesh PreviewMesh;
}
