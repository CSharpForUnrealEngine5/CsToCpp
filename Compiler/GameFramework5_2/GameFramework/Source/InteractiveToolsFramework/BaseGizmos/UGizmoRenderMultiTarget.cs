namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoInterfaces.h")]
public partial class UGizmoRenderMultiTarget : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>* Updates the visibility state of the specified gizmo part.</summary>
	public virtual void UpdateVisibilityState(bool bVisible,uint InPartIdentifier) {}
}
