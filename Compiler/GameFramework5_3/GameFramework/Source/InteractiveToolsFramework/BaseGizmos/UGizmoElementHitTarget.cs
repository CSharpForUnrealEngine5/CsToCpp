namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGizmoElementHitTarget is an IGizmoClickTarget implementation that</summary>
[CppInclude("BaseGizmos/GizmoElementHitTargets.h")]
public partial class UGizmoElementHitTarget : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Gizmo element.</summary>
	public UGizmoElementBase GizmoElement;
	///<summary>GizmoViewContext</summary>
	public UGizmoViewContext GizmoViewContext;
	///<summary>GizmoTransformProxy</summary>
	public UTransformProxy GizmoTransformProxy;
}
