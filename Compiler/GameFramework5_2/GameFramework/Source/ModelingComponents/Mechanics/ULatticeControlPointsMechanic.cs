#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Mechanics/LatticeControlPointsMechanic.h")]
public partial class ULatticeControlPointsMechanic : UInteractionMechanic {
// LatticeControlPointsMechanic
	public APreviewGeometryActor PreviewGeometryActor;
	public UPointSetComponent DrawnControlPoints;
	public ULineSetComponent DrawnLatticeEdges;
	public UTransformProxy PointTransformProxy;
	public UCombinedTransformGizmo PointTransformGizmo;
	public URectangleMarqueeMechanic MarqueeMechanic;
}
