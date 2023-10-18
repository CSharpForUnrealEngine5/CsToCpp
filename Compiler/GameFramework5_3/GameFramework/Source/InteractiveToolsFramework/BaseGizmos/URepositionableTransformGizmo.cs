namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A transform gizmo that also allows the user to reposition it by middle-clicking rotation/translation components.</summary>
[CppInclude("BaseGizmos/RepositionableTransformGizmo.h")]
public partial class URepositionableTransformGizmo : UCombinedTransformGizmo {
	public static UClass StaticClass() {return default;}
	///<summary>RepositionStateTarget</summary>
	public UGizmoTransformChangeStateTarget RepositionStateTarget;
}
