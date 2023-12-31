namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGizmoTransformProxyTransformSource implements IGizmoTransformSource (via UGizmoBaseTransformSource)</summary>
[CppInclude("BaseGizmos/TransformSources.h")]
public partial class UGizmoTransformProxyTransformSource : UGizmoBaseTransformSource {
	public static UClass StaticClass() {return default;}
	///<summary>Proxy</summary>
	public UTransformProxy Proxy;
}
