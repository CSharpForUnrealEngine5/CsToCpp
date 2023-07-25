#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoElementCylinder.h")]
///<summary>Simple object intended to be used as part of 3D Gizmos.</summary>
public partial class UGizmoElementCylinder : UGizmoElementBase {
// GizmoElementCylinder
	public FVector Base;
	public FVector Direction;
	public float Height;
	public float Radius;
	public int NumSides;
}
