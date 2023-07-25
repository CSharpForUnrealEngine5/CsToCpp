#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoCircleComponent.h")]
///<summary>Simple Component intended to be used as part of 3D Gizmos.</summary>
public partial class UGizmoCircleComponent : UGizmoBaseComponent {
// GizmoCircleComponent
	public FVector Normal;
	public float Radius;
	public float Thickness;
	public int NumSides;
	public bool bViewAligned;
	public bool bDrawFullCircle;
	public bool bOnlyAllowFrontFacingHits;
}
