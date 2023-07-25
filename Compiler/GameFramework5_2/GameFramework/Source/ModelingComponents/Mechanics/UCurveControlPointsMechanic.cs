#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Mechanics/CurveControlPointsMechanic.h")]
///<summary>A mechanic for displaying a sequence of control points and moving them about. Has an interactive initialization mode for</summary>
public partial class UCurveControlPointsMechanic : UInteractionMechanic {
// CurveControlPointsMechanic
	public USingleClickInputBehavior ClickBehavior;
	public UMouseHoverBehavior HoverBehavior;
	public APreviewGeometryActor PreviewGeometryActor;
	public UPointSetComponent DrawnControlPoints;
	public ULineSetComponent DrawnControlSegments;
	public UPointSetComponent PreviewPoint;
	public ULineSetComponent PreviewSegment;
	public UTransformProxy PointTransformProxy;
	public UCombinedTransformGizmo PointTransformGizmo;
}
