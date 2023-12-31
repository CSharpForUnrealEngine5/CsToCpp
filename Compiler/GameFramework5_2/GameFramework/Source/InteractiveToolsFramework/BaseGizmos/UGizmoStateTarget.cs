namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoInterfaces.h")]
public partial class UGizmoStateTarget : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>BeginUpdate is called before a standard Gizmo begins changing a parameter (via a ParameterSource)</summary>
	public virtual void BeginUpdate() {}
	///<summary>EndUpdate is called when a standard Gizmo is finished changing a parameter (via a ParameterSource)</summary>
	public virtual void EndUpdate() {}
}
