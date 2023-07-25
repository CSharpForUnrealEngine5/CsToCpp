#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/CombinedTransformGizmo.h")]
///<summary>UCombinedTransformGizmo provides standard Transformation Gizmo interactions,</summary>
public partial class UCombinedTransformGizmo : UInteractiveGizmo {
// CombinedTransformGizmo
	public UTransformProxy ActiveTarget;
	public bool bSnapToWorldGrid;
	public bool bGridSizeIsExplicit;
	public FVector ExplicitGridSize;
	public bool bRotationGridSizeIsExplicit;
	public FRotator ExplicitRotationGridSize;
	public bool bSnapToWorldRotGrid;
	public bool bUseContextCoordinateSystem;
	public EToolContextCoordinateSystem CurrentCoordinateSystem;
	public bool bUseContextGizmoMode;
	public EToolContextTransformGizmoMode ActiveGizmoMode;
	public TArray<UPrimitiveComponent> ActiveComponents;
	public TArray<UInteractiveGizmo> ActiveGizmos;
	public UGizmoConstantFrameAxisSource CameraAxisSource;
	public UGizmoComponentAxisSource AxisXSource;
	public UGizmoComponentAxisSource AxisYSource;
	public UGizmoComponentAxisSource AxisZSource;
	public UGizmoComponentAxisSource UnitAxisXSource;
	public UGizmoComponentAxisSource UnitAxisYSource;
	public UGizmoComponentAxisSource UnitAxisZSource;
	public UGizmoTransformChangeStateTarget StateTarget;
}
