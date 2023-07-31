#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGizmoElementHitMultiTarget is an IGizmoClickMultiTarget implementation that</summary>
[CppInclude("BaseGizmos/GizmoElementHitTargets.h")]
public partial class UGizmoElementHitMultiTarget : UObject {
	///<summary>Gizmo element.</summary>
	public UGizmoElementBase GizmoElement;
	///<summary>GizmoViewContext</summary>
	public UGizmoViewContext GizmoViewContext;
	///<summary>GizmoTransformProxy</summary>
	public UTransformProxy GizmoTransformProxy;
}
