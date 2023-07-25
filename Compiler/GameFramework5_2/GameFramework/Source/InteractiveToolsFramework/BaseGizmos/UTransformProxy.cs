#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/TransformProxy.h")]
///<summary>UTransformProxy is used to transform a set of sub-objects. An internal</summary>
public partial class UTransformProxy : UObject {
// TransformProxy
	public bool bRotatePerObject;
	public bool bSetPivotMode;
	public FTransform SharedTransform;
	public FTransform InitialSharedTransform;
}
