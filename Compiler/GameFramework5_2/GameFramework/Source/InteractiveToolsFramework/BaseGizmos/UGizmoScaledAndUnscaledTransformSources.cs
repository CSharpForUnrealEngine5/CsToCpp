#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/TransformSources.h")]
///<summary>A wrapper around two IGizmoTransformSource's that generally forwards transforms to/from its ScaledTransformSource,</summary>
public partial class UGizmoScaledAndUnscaledTransformSources : UGizmoBaseTransformSource {
// GizmoScaledAndUnscaledTransformSources
	public object /*ScaledTransformSource*/ ScaledTransformSource;
	public object /*UnscaledTransformSource*/ UnscaledTransformSource;
}
