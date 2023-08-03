#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for simple Components intended to be used as part of 3D Gizmos.</summary>
[CppInclude("BaseGizmos/GizmoBaseComponent.h")]
public partial class UGizmoBaseComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Color</summary>
	public FLinearColor Color;
	///<summary>HoverSizeMultiplier</summary>
	public float HoverSizeMultiplier;
	///<summary>PixelHitDistanceThreshold</summary>
	public float PixelHitDistanceThreshold;
	///<summary>UpdateHoverState</summary>
	public  void UpdateHoverState(bool bHoveringIn) {}
	///<summary>UpdateWorldLocalState</summary>
	public  void UpdateWorldLocalState(bool bWorldIn) {}
	///<summary>GizmoViewContext</summary>
	public UGizmoViewContext GizmoViewContext;
}
