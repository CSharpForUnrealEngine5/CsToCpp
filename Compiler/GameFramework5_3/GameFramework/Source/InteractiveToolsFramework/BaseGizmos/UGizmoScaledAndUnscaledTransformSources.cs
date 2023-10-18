namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A wrapper around two IGizmoTransformSource&#39;s that generally forwards transforms to/from its ScaledTransformSource,</summary>
[CppInclude("BaseGizmos/TransformSources.h")]
public partial class UGizmoScaledAndUnscaledTransformSources : UGizmoBaseTransformSource {
	public static UClass StaticClass() {return default;}
	///<summary>ScaledTransformSource</summary>
	public object /*ScaledTransformSource*/ ScaledTransformSource;
	///<summary>UnscaledTransformSource</summary>
	public object /*UnscaledTransformSource*/ UnscaledTransformSource;
}
