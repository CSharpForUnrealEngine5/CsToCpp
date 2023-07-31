#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A transform gizmo that also allows the user to reposition it by middle-clicking rotation/translation components.</summary>
[CppInclude("BaseGizmos/RepositionableTransformGizmo.h")]
public partial class URepositionableTransformGizmo : UCombinedTransformGizmo {
	///<summary>RepositionStateTarget</summary>
	public UGizmoTransformChangeStateTarget RepositionStateTarget;
}
