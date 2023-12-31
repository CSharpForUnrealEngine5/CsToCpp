namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Polymodeling/OffsetMeshSelectionTool.h")]
public partial class UOffsetMeshSelectionToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>The Extrusion Distance used in Fixed Input Mode</summary>
	public double OffsetDistance;
	///<summary>Control how the Offset Area should be displaced</summary>
	public EOffsetMeshSelectionDirectionMode Direction;
	///<summary>Specify the number of subdivisions along the sides of the Extrusion</summary>
	public int NumSubdivisions;
	///<summary>Specify the Crease Angle used to split the sides of the Extrusion into separate Groups</summary>
	public double CreaseAngle;
	///<summary>If the Offset Area has a fully open border, this option determines if Extrusion will create a Solid mesh or leave the base &quot;open&quot;</summary>
	public bool bShellsToSolids;
	///<summary>Control whether a single Group should be generated along the sides of the Extrusion, or multiple Groups based on the adjacent Groups around the Offset Area border</summary>
	public bool bInferGroupsFromNbrs;
	///<summary>Control whether a new Group is generated for each Subdivision</summary>
	public bool bGroupPerSubdivision;
	///<summary>Control whether groups in the Offset Area are mapped to new Groups, or replaced with a single new Group</summary>
	public bool bReplaceSelectionGroups;
	///<summary>The automatically-generated UVs on the sides of the Extrusion are scaled by this value</summary>
	public double UVScale;
	///<summary>Control whether a separate UV island should be generated for each output Group on the sides of the Extrusion, or a single UV island wrapping around the entire &quot;tube&quot;</summary>
	public bool bUVIslandPerGroup;
	///<summary>Control whether SetMaterialID is assigned to all triangles along the sides of the Extrusion, or if MaterialIDs should be inferred from the Offset Area</summary>
	public bool bInferMaterialID;
	///<summary>Constant Material ID used when MaterialIDs are not being inferred, or no adjacent MaterialID exists</summary>
	public int SetMaterialID;
	///<summary>Control whether the original Mesh Materials should be shown, or a visualization of the Offset Groups</summary>
	public bool bShowInputMaterials;
}
