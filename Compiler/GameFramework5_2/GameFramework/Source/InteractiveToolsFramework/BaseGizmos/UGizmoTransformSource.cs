namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoInterfaces.h")]
public partial class UGizmoTransformSource : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>GetTransform</summary>
	public virtual FTransform GetTransform() { return default; }
	///<summary>SetTransform</summary>
	public virtual void SetTransform(FTransform NewTransform) {}
}
