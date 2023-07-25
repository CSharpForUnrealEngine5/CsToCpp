#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CSGMeshesTool.h")]
///<summary>Standard properties of the CSG operation</summary>
public partial class UCSGMeshesToolProperties : UInteractiveToolPropertySet {
// CSGMeshesToolProperties
	public ECSGOperation Operation;
	public bool bTryFixHoles;
	public bool bTryCollapseEdges;
	public float WindingThreshold;
	public bool bShowNewBoundaries;
	public bool bShowSubtractedMesh;
	public float SubtractedMeshOpacity;
	public FLinearColor SubtractedMeshColor;
	public bool bUseFirstMeshMaterials;
}
