namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USkeletalMeshGizmoWrapper is a wrapper class to handle a Transform Gizmo and it&#39;s Transform proxy so that it can</summary>
[CppInclude("SkeletalMeshGizmoUtils.h")]
public partial class USkeletalMeshGizmoWrapper : USkeletalMeshGizmoWrapperBase {
	public static UClass StaticClass() {return default;}
	///<summary>TransformGizmo</summary>
	public UTransformGizmo TransformGizmo;
	///<summary>TransformProxy</summary>
	public USkeletonTransformProxy TransformProxy;
}
