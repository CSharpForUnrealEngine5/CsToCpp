#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoElementArrow.h")]
public partial class UGizmoElementArrow : UGizmoElementBase {
// GizmoElementArrow
	public UGizmoElementCylinder CylinderElement;
	public UGizmoElementCone ConeElement;
	public UGizmoElementBox BoxElement;
	public FVector Base;
	public FVector Direction;
	public FVector SideDirection;
	public float BodyLength;
	public float BodyRadius;
	public float HeadLength;
	public float HeadRadius;
	public int NumSides;
	public EGizmoElementArrowHeadType HeadType;
}
