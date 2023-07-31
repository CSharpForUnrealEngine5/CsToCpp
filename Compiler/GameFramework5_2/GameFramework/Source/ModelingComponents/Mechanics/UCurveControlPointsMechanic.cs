#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A mechanic for displaying a sequence of control points and moving them about. Has an interactive initialization mode for</summary>
[CppInclude("Mechanics/CurveControlPointsMechanic.h")]
public partial class UCurveControlPointsMechanic : UInteractionMechanic {
	///<summary>Behaviors used for moving points around and hovering them</summary>
	public USingleClickInputBehavior ClickBehavior;
	///<summary>HoverBehavior</summary>
	public UMouseHoverBehavior HoverBehavior;
	///<summary>Used for displaying points/segments</summary>
	public APreviewGeometryActor PreviewGeometryActor;
	///<summary>DrawnControlPoints</summary>
	public UPointSetComponent DrawnControlPoints;
	///<summary>DrawnControlSegments</summary>
	public ULineSetComponent DrawnControlSegments;
	///<summary>These get drawn separately because the other components have to be 1:1 with the control</summary>
	public UPointSetComponent PreviewPoint;
	///<summary>PreviewSegment</summary>
	public ULineSetComponent PreviewSegment;
	///<summary>Support for gizmo. Since the points aren&#39;t individual components, we don&#39;t actually use UTransformProxy</summary>
	public UTransformProxy PointTransformProxy;
	///<summary>PointTransformGizmo</summary>
	public UCombinedTransformGizmo PointTransformGizmo;
}
