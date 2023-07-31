#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGizmoComponentWorldTransformSource implements IGizmoTransformSource (via UGizmoBaseTransformSource)</summary>
[CppInclude("BaseGizmos/TransformSources.h")]
public partial class UGizmoComponentWorldTransformSource : UGizmoBaseTransformSource {
	///<summary>Component</summary>
	public USceneComponent Component;
	///<summary>If true, Component-&gt;Modify() is called on SetTransform</summary>
	public bool bModifyComponentOnTransform;
}
