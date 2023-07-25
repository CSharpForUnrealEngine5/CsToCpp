#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/IntervalGizmo.h")]
public partial class UIntervalGizmo : UInteractiveGizmo {
// IntervalGizmo
	public UGizmoTransformChangeStateTarget StateTarget;
	public UTransformProxy TransformProxy;
	public TArray<UPrimitiveComponent> ActiveComponents;
	public TArray<UInteractiveGizmo> ActiveGizmos;
	public UGizmoComponentAxisSource AxisYSource;
	public UGizmoComponentAxisSource AxisZSource;
}
