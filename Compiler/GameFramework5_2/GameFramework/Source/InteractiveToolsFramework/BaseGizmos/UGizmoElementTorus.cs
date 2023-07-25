#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoElementTorus.h")]
///<summary>Simple object intended to be used as part of 3D Gizmos.</summary>
public partial class UGizmoElementTorus : UGizmoElementCircleBase {
// GizmoElementTorus
	public double InnerRadius;
	public int NumInnerSlices;
	public bool bEndCaps;
}
