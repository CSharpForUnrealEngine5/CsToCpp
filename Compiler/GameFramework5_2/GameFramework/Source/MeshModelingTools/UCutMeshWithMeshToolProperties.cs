#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CutMeshWithMeshTool.h")]
///<summary>Standard properties of the CutMeshWithMesh operation</summary>
public partial class UCutMeshWithMeshToolProperties : UInteractiveToolPropertySet {
// CutMeshWithMeshToolProperties
	public bool bTryFixHoles;
	public bool bTryCollapseEdges;
	public float WindingThreshold;
	public bool bShowNewBoundaries;
	public bool bUseFirstMeshMaterials;
}
