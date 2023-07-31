#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Component intended to be used as part of 3D Gizmos.</summary>
[CppInclude("BaseGizmos/GizmoArrowComponent.h")]
public partial class UGizmoArrowComponent : UGizmoBaseComponent {
	///<summary>Direction</summary>
	public FVector Direction;
	///<summary>Gap</summary>
	public float Gap;
	///<summary>Length</summary>
	public float Length;
	///<summary>Thickness</summary>
	public float Thickness;
}
