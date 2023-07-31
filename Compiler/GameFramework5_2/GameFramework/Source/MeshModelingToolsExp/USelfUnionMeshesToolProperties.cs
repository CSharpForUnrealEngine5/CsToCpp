#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties of the self-union operation</summary>
[CppInclude("SelfUnionMeshesTool.h")]
public partial class USelfUnionMeshesToolProperties : UInteractiveToolPropertySet {
	///<summary>If true, remove open, visible geometry</summary>
	public bool bTrimFlaps;
	///<summary>Try to fill holes created by the merge, e.g. due to numerical errors</summary>
	public bool bTryFixHoles;
	///<summary>Try to collapse extra edges created by the merge</summary>
	public bool bTryCollapseEdges;
	///<summary>Threshold to determine whether a triangle in one mesh is inside or outside of the other</summary>
	public float WindingThreshold;
	///<summary>Show boundary edges created by the merge (often due to numerical error)</summary>
	public bool bShowNewBoundaryEdges;
	///<summary>If true, only the first mesh will keep its materials assignments; all other triangles will be assigned material 0</summary>
	public bool bOnlyUseFirstMeshMaterials;
}
