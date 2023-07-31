#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoInterfaces.h")]
public partial class UGizmoStateTarget : UInterface {
	///<summary>BeginUpdate is called before a standard Gizmo begins changing a parameter (via a ParameterSource)</summary>
	public  void BeginUpdate() {}
	///<summary>EndUpdate is called when a standard Gizmo is finished changing a parameter (via a ParameterSource)</summary>
	public  void EndUpdate() {}
}
