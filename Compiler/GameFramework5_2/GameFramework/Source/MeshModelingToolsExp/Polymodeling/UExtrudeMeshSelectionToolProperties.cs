#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Polymodeling/ExtrudeMeshSelectionTool.h")]
public partial class UExtrudeMeshSelectionToolProperties : UInteractiveToolPropertySet {
// ExtrudeMeshSelectionToolProperties
	public EExtrudeMeshSelectionInteractionMode InputMode;
	public double ExtrudeDistance;
	public EExtrudeMeshSelectionRegionModifierMode RegionMode;
	public int NumSubdivisions;
	public double CreaseAngle;
	public double RaycastMaxDistance;
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
