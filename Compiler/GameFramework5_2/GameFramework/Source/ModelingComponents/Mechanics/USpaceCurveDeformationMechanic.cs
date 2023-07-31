#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Mechanics/SpaceCurveDeformationMechanic.h")]
public partial class USpaceCurveDeformationMechanic : UInteractionMechanic {
	///<summary>Behaviors used for moving points around and hovering them</summary>
	public USingleClickInputBehavior ClickBehavior;
	///<summary>HoverBehavior</summary>
	public UMouseHoverBehavior HoverBehavior;
	///<summary>TransformProperties</summary>
	public USpaceCurveDeformationMechanicPropertySet TransformProperties;
	///<summary>Used for displaying points/segments</summary>
	public APreviewGeometryActor PreviewGeometryActor;
	///<summary>RenderPoints</summary>
	public UPointSetComponent RenderPoints;
	///<summary>RenderSegments</summary>
	public ULineSetComponent RenderSegments;
	///<summary>Support for gizmo. Since the points aren&#39;t individual components, we don&#39;t actually use UTransformProxy</summary>
	public UTransformProxy PointTransformProxy;
	///<summary>PointTransformGizmo</summary>
	public UCombinedTransformGizmo PointTransformGizmo;
}
