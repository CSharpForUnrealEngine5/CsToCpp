namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoElementShared.h")]
///<summary>Visible/hittable state of gizmo element</summary>
public enum EGizmoElementState {
	None=0,
	Visible=-1,
	Hittable=-1,
	VisibleAndHittable=-1,
}
