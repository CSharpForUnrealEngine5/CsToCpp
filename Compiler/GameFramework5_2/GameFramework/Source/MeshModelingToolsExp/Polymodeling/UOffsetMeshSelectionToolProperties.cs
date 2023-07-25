#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Polymodeling/OffsetMeshSelectionTool.h")]
public partial class UOffsetMeshSelectionToolProperties : UInteractiveToolPropertySet {
// OffsetMeshSelectionToolProperties
	public double OffsetDistance;
	public EOffsetMeshSelectionDirectionMode Direction;
	public int NumSubdivisions;
	public double CreaseAngle;
	public bool bShellsToSolids;
	public bool bInferGroupsFromNbrs;
	public bool bGroupPerSubdivision;
	public bool bReplaceSelectionGroups;
	public double UVScale;
	public bool bUVIslandPerGroup;
	public bool bInferMaterialID;
	public int SetMaterialID;
	public bool bShowInputMaterials;
}
