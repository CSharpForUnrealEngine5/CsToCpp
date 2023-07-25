#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/ParameterToTransformAdapters.h")]
///<summary>UGizmoAxisRotationParameterSource is an IGizmoFloatParameterSource implementation that</summary>
public partial class UGizmoAxisRotationParameterSource : UGizmoBaseFloatParameterSource {
// GizmoAxisRotationParameterSource
	public object /*AxisSource*/ AxisSource;
	public object /*TransformSource*/ TransformSource;
	public float Angle;
	public FGizmoFloatParameterChange LastChange;
	public FVector CurRotationAxis;
	public FVector CurRotationOrigin;
	public FTransform InitialTransform;
}
