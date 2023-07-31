#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>These are properties that do not get enabled/disabled based on the action</summary>
[CppInclude("EditMeshPolygonsTool.h")]
public partial class UPolyEditCommonProperties : UInteractiveToolPropertySet {
	///<summary>bShowWireframe</summary>
	public bool bShowWireframe;
	///<summary>bShowSelectableCorners</summary>
	public bool bShowSelectableCorners;
	///<summary>When true, allows the transform gizmo to be rendered</summary>
	public bool bGizmoVisible;
	///<summary>Determines whether, on selection changes, the gizmo&#39;s rotation is taken from the object transform, or from the geometry</summary>
	public ELocalFrameMode LocalFrameMode;
	///<summary>When true, keeps rotation of gizmo constant through selection changes and manipulations</summary>
	public bool bLockRotation;
	///<summary>This gets updated internally so that properties can respond to whether the coordinate system is set to local or global</summary>
	public bool bLocalCoordSystem;
}
