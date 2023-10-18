namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSpaceDeformerTool.h")]
public partial class UMeshSpaceDeformerToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>SelectedOperationType</summary>
	public ENonlinearOperationType SelectedOperationType;
	///<summary>The upper bound to the region of space which the operation will affect. Measured along the gizmo Z axis from the gizmo center.</summary>
	public float UpperBoundsInterval;
	///<summary>The lower bound to the region of space which the operation will affect. Measured along the gizmo Z axis from the gizmo center.</summary>
	public float LowerBoundsInterval;
	///<summary>A line along the Z axis of the gizmo from lower bound to upper bound will be bent into a perfect arc of this</summary>
	public float BendDegrees;
	///<summary>Degrees of twist to from the lower bound to the upper bound along the gizmo Z axis.</summary>
	public float TwistDegrees;
	///<summary>Determines the profile used as a displacement</summary>
	public EFlareProfileType FlareProfileType;
	///<summary>Determines how much to flare perpendicular to the Z axis. When set to 100%, points are moved double the distance</summary>
	public float FlarePercentY;
	///<summary>If true, flaring is applied along the gizmo X and Y axis the same amount.</summary>
	public bool bLockXAndYFlaring;
	///<summary>Determines how much to flare perpendicular to the Z axis in the X direction if the flaring is not locked</summary>
	public float FlarePercentX;
	///<summary>If true, the &quot;bottom&quot; of the mesh relative to the gizmo Z axis will stay in place while the rest bends or twists. If false, the bend</summary>
	public bool bLockBottom;
	///<summary>bShowOriginalMesh</summary>
	public bool bShowOriginalMesh;
	///<summary>bDrawVisualization</summary>
	public bool bDrawVisualization;
	///<summary>When true, Ctrl+click not only moves the gizmo to the clicked location, but also aligns the Z axis with the normal at that point.</summary>
	public bool bAlignToNormalOnCtrlClick;
}
