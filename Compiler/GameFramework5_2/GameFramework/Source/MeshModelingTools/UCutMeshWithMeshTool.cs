#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CutMeshWithMeshTool.h")]
///<summary>UCutMeshWithMeshTool cuts an input mesh into two pieces based on a second input mesh.</summary>
public partial class UCutMeshWithMeshTool : UBaseCreateFromSelectedTool {
// CutMeshWithMeshTool
	public UCutMeshWithMeshToolProperties CutProperties;
	public UPreviewMesh IntersectPreviewMesh;
	public ULineSetComponent DrawnLineSet;
}
