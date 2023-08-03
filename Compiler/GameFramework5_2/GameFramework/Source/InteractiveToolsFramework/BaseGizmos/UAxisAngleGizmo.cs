#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/AxisAngleGizmo.h")]
public partial class UAxisAngleGizmo : UInteractiveGizmo {
	public static UClass StaticClass() {return default;}
	///<summary>AxisSource</summary>
	public object /*AxisSource*/ AxisSource;
	///<summary>AngleSource</summary>
	public object /*AngleSource*/ AngleSource;
	///<summary>HitTarget</summary>
	public object /*HitTarget*/ HitTarget;
	///<summary>StateTarget</summary>
	public object /*StateTarget*/ StateTarget;
	///<summary>The mouse click behavior of the gizmo is accessible so that it can be modified to use different mouse keys.</summary>
	public UClickDragInputBehavior MouseBehavior;
	///<summary>bInInteraction</summary>
	public bool bInInteraction;
	///<summary>RotationOrigin</summary>
	public FVector RotationOrigin;
	///<summary>RotationAxis</summary>
	public FVector RotationAxis;
	///<summary>RotationPlaneX</summary>
	public FVector RotationPlaneX;
	///<summary>RotationPlaneY</summary>
	public FVector RotationPlaneY;
	///<summary>InteractionStartPoint</summary>
	public FVector InteractionStartPoint;
	///<summary>InteractionCurPoint</summary>
	public FVector InteractionCurPoint;
	///<summary>InteractionStartAngle</summary>
	public float InteractionStartAngle;
	///<summary>InteractionCurAngle</summary>
	public float InteractionCurAngle;
}
