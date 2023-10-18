namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Polymodeling/ExtrudeMeshSelectionTool.h")]
public partial class UExtrudeMeshSelectionToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Control how the Extruded Area should be Transformed</summary>
	public EExtrudeMeshSelectionInteractionMode InputMode;
	///<summary>The Extrusion Distance used in Fixed Input Mode</summary>
	public double ExtrudeDistance;
	///<summary>Control how the Extruded Area should be deformed as part of the Extrusion</summary>
	public EExtrudeMeshSelectionRegionModifierMode RegionMode;
	///<summary>Specify the number of subdivisions along the sides of the Extrusion</summary>
	public int NumSubdivisions;
	///<summary>Specify the Crease Angle used to split the sides of the Extrusion into separate Groups</summary>
	public double CreaseAngle;
	///<summary>Control the maximum distance each vertex may be moved in Raycast To Plane Mode</summary>
	public double RaycastMaxDistance;
	///<summary>If the Extruded Area has a fully open border, this option determines if Extrusion will create a Solid mesh or leave the base &quot;open&quot;</summary>
	public bool bShellsToSolids;
	///<summary>Control whether a single Group should be generated along the sides of the Extrusion, or multiple Groups based on the adjacent Groups around the Extruded Area border</summary>
	public bool bInferGroupsFromNbrs;
	///<summary>Control whether a new Group is generated for each Subdivision</summary>
	public bool bGroupPerSubdivision;
	///<summary>Control whether groups in the Extruded Area are mapped to new Groups, or replaced with a single new Group</summary>
	public bool bReplaceSelectionGroups;
	///<summary>The automatically-generated UVs on the sides of the Extrusion are scaled by this value</summary>
	public double UVScale;
	///<summary>Control whether a separate UV island should be generated for each output Group on the sides of the Extrusion, or a single UV island wrapping around the entire &quot;tube&quot;</summary>
	public bool bUVIslandPerGroup;
	///<summary>Control whether SetMaterialID is assigned to all triangles along the sides of the Extrusion, or if MaterialIDs should be inferred from the Extruded Area</summary>
	public bool bInferMaterialID;
	///<summary>Constant Material ID used when MaterialIDs are not being inferred, or no adjacent MaterialID exists</summary>
	public int SetMaterialID;
	///<summary>Control whether the original Mesh Materials should be shown, or a visualization of the extruded Groups</summary>
	public bool bShowInputMaterials;
}
