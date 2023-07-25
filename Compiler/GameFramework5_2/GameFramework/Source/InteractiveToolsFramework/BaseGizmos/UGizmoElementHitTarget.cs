#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoElementHitTargets.h")]
///<summary>UGizmoElementHitTarget is an IGizmoClickTarget implementation that</summary>
public partial class UGizmoElementHitTarget : UObject {
// GizmoElementHitTarget
	public UGizmoElementBase GizmoElement;
	public UGizmoViewContext GizmoViewContext;
	public UTransformProxy GizmoTransformProxy;
}
