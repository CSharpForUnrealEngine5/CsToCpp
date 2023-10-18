namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UCutMeshWithMeshTool cuts an input mesh into two pieces based on a second input mesh.</summary>
[CppInclude("CutMeshWithMeshTool.h")]
public partial class UCutMeshWithMeshTool : UBaseCreateFromSelectedTool {
	public static UClass StaticClass() {return default;}
	///<summary>CutProperties</summary>
	public UCutMeshWithMeshToolProperties CutProperties;
	///<summary>IntersectPreviewMesh</summary>
	public UPreviewMesh IntersectPreviewMesh;
	///<summary>DrawnLineSet</summary>
	public ULineSetComponent DrawnLineSet;
}
