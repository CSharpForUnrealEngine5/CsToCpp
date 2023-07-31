#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AddPrimitiveTool.h")]
public partial class UProceduralShapeToolProperties : UInteractiveToolPropertySet {
	///<summary>How PolyGroups are assigned to shape primitives.</summary>
	public EMakeMeshPolygroupMode PolygroupMode;
	///<summary>How the shape is placed in the scene.</summary>
	public EMakeMeshPlacementType TargetSurface;
	///<summary>Location of pivot within the shape</summary>
	public EMakeMeshPivotLocation PivotLocation;
	///<summary>Rotation of the shape around its up axis</summary>
	public float Rotation;
	///<summary>If true, aligns the shape along the normal of the surface it is placed on.</summary>
	public bool bAlignToNormal;
	///<summary>Show a gizmo to allow the mesh to be repositioned after the initial placement click.</summary>
	public bool bShowGizmo;
	///<summary>bShowGizmoOptions</summary>
	public bool bShowGizmoOptions;
}
