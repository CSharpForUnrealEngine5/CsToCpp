#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Mechanics/LatticeControlPointsMechanic.h")]
public partial class ULatticeControlPointsMechanic : UInteractionMechanic {
	///<summary>Used for displaying points/segments</summary>
	public APreviewGeometryActor PreviewGeometryActor;
	///<summary>DrawnControlPoints</summary>
	public UPointSetComponent DrawnControlPoints;
	///<summary>DrawnLatticeEdges</summary>
	public ULineSetComponent DrawnLatticeEdges;
	///<summary>Support for gizmo. Since the points aren&#39;t individual components, we don&#39;t actually use UTransformProxy</summary>
	public UTransformProxy PointTransformProxy;
	///<summary>PointTransformGizmo</summary>
	public UCombinedTransformGizmo PointTransformGizmo;
	///<summary>Support for selection</summary>
	public URectangleMarqueeMechanic MarqueeMechanic;
}
