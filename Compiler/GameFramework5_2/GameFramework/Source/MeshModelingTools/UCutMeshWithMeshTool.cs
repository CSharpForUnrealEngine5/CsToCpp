#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UCutMeshWithMeshTool cuts an input mesh into two pieces based on a second input mesh.</summary>
[CppInclude("CutMeshWithMeshTool.h")]
public partial class UCutMeshWithMeshTool : UBaseCreateFromSelectedTool {
	///<summary>CutProperties</summary>
	public UCutMeshWithMeshToolProperties CutProperties;
	///<summary>IntersectPreviewMesh</summary>
	public UPreviewMesh IntersectPreviewMesh;
	///<summary>DrawnLineSet</summary>
	public ULineSetComponent DrawnLineSet;
}
