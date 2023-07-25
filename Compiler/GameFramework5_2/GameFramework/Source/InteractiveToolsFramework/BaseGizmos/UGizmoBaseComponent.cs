#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoBaseComponent.h")]
///<summary>Base class for simple Components intended to be used as part of 3D Gizmos.</summary>
public partial class UGizmoBaseComponent : UPrimitiveComponent {
// GizmoBaseComponent
	public FLinearColor Color;
	public float HoverSizeMultiplier;
	public float PixelHitDistanceThreshold;
	public void UpdateHoverState(bool bHoveringIn) {}
	public void UpdateWorldLocalState(bool bWorldIn) {}
	public UGizmoViewContext GizmoViewContext;
}
