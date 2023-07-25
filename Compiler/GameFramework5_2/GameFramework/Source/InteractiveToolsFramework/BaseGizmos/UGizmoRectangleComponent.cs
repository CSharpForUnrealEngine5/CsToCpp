#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoRectangleComponent.h")]
///<summary>Simple Component intended to be used as part of 3D Gizmos.</summary>
public partial class UGizmoRectangleComponent : UGizmoBaseComponent {
// GizmoRectangleComponent
	public FVector DirectionX;
	public FVector DirectionY;
	public bool bOrientYAccordingToCamera;
	public float OffsetX;
	public float OffsetY;
	public float LengthX;
	public float LengthY;
	public float Thickness;
	public byte SegmentFlags;
}
