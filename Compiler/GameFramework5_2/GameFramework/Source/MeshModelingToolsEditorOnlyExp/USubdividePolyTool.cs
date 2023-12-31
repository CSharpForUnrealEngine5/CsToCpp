namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tool actual</summary>
[CppInclude("SubdividePolyTool.h")]
public partial class USubdividePolyTool : USingleSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>PreviewMesh</summary>
	public UPreviewMesh PreviewMesh;
	///<summary>Properties</summary>
	public USubdividePolyToolProperties Properties;
	///<summary>PreviewGeometry</summary>
	public UPreviewGeometry PreviewGeometry;
}
