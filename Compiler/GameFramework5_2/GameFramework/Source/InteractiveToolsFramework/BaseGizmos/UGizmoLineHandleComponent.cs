#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoLineHandleComponent.h")]
///<summary>Simple Component intended to be used as part of 3D Gizmos.</summary>
public partial class UGizmoLineHandleComponent : UGizmoBaseComponent {
// GizmoLineHandleComponent
	public FVector Normal;
	public float HandleSize;
	public float Thickness;
	public FVector Direction;
	public float Length;
	public bool bImageScale;
}
