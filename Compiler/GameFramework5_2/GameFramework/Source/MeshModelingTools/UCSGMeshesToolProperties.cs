#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties of the CSG operation</summary>
[CppInclude("CSGMeshesTool.h")]
public partial class UCSGMeshesToolProperties : UInteractiveToolPropertySet {
	///<summary>Type of Boolean operation</summary>
	public ECSGOperation Operation;
	///<summary>Try to fill holes created by the Boolean operation, e.g. due to numerical errors</summary>
	public bool bTryFixHoles;
	///<summary>Try to collapse extra edges created by the Boolean operation</summary>
	public bool bTryCollapseEdges;
	///<summary>Threshold to determine whether a triangle in one mesh is inside or outside of the other</summary>
	public float WindingThreshold;
	///<summary>Show boundary edges created by the Boolean operation, which might happen due to numerical errors</summary>
	public bool bShowNewBoundaries;
	///<summary>Show a translucent version of the subtracted mesh, to help visualize geometry that is being removed</summary>
	public bool bShowSubtractedMesh;
	///<summary>Opacity of the translucent subtracted mesh</summary>
	public float SubtractedMeshOpacity;
	///<summary>Color of the translucent subtracted mesh</summary>
	public FLinearColor SubtractedMeshColor;
	///<summary>If true, only the first mesh will keep its material assignments, and all other faces will have the first material assigned</summary>
	public bool bUseFirstMeshMaterials;
}
