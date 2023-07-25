#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Mechanics/SpaceCurveDeformationMechanic.h")]
public partial class USpaceCurveDeformationMechanic : UInteractionMechanic {
// SpaceCurveDeformationMechanic
	public USingleClickInputBehavior ClickBehavior;
	public UMouseHoverBehavior HoverBehavior;
	public USpaceCurveDeformationMechanicPropertySet TransformProperties;
	public APreviewGeometryActor PreviewGeometryActor;
	public UPointSetComponent RenderPoints;
	public ULineSetComponent RenderSegments;
	public UTransformProxy PointTransformProxy;
	public UCombinedTransformGizmo PointTransformGizmo;
}
