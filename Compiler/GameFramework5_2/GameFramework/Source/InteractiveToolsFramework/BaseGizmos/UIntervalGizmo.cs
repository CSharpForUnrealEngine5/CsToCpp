#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/IntervalGizmo.h")]
public partial class UIntervalGizmo : UInteractiveGizmo {
	public static UClass StaticClass() {return default;}
	///<summary>State target is shared across gizmos, and created internally during SetActiveTarget()</summary>
	public UGizmoTransformChangeStateTarget StateTarget;
	///<summary>The gizmo tracks the location and orientation of the transform in this TransformProxy.</summary>
	public UTransformProxy TransformProxy;
	///<summary>list of current-active child components</summary>
	public TArray<UPrimitiveComponent> ActiveComponents;
	///<summary>list of currently-active child gizmos</summary>
	public TArray<UInteractiveGizmo> ActiveGizmos;
	///<summary>Y-axis source is shared across Gizmos, and created internally during SetActiveTarget()</summary>
	public UGizmoComponentAxisSource AxisYSource;
	///<summary>Z-axis source is shared across Gizmos, and created internally during SetActiveTarget()</summary>
	public UGizmoComponentAxisSource AxisZSource;
}
