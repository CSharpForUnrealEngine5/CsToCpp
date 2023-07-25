#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SelfUnionMeshesTool.h")]
///<summary>Standard properties of the self-union operation</summary>
public partial class USelfUnionMeshesToolProperties : UInteractiveToolPropertySet {
// SelfUnionMeshesToolProperties
	public bool bTrimFlaps;
	public bool bTryFixHoles;
	public bool bTryCollapseEdges;
	public float WindingThreshold;
	public bool bShowNewBoundaryEdges;
	public bool bOnlyUseFirstMeshMaterials;
}
