namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@deprecated Use UGizmoScaledAndUnscaledTransformSources instead.</summary>
[CppInclude("BaseGizmos/TransformSources.h")]
public partial class UGizmoScaledTransformSource : UGizmoBaseTransformSource {
	public static UClass StaticClass() {return default;}
	///<summary>Child transform source</summary>
	public object /*ChildTransformSource*/ ChildTransformSource;
}
