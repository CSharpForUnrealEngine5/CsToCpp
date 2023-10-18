namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGizmoComponentWorldTransformSource implements IGizmoTransformSource (via UGizmoBaseTransformSource)</summary>
[CppInclude("BaseGizmos/TransformSources.h")]
public partial class UGizmoComponentWorldTransformSource : UGizmoBaseTransformSource {
	public static UClass StaticClass() {return default;}
	///<summary>Component</summary>
	public USceneComponent Component;
	///<summary>If true, Component-&gt;Modify() is called on SetTransform</summary>
	public bool bModifyComponentOnTransform;
}
