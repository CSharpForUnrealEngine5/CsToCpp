#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A wrapper around two IGizmoTransformSource&#39;s that generally forwards transforms to/from its ScaledTransformSource,</summary>
[CppInclude("BaseGizmos/TransformSources.h")]
public partial class UGizmoScaledAndUnscaledTransformSources : UGizmoBaseTransformSource {
	///<summary>ScaledTransformSource</summary>
	public object /*ScaledTransformSource*/ ScaledTransformSource;
	///<summary>UnscaledTransformSource</summary>
	public object /*UnscaledTransformSource*/ UnscaledTransformSource;
}
