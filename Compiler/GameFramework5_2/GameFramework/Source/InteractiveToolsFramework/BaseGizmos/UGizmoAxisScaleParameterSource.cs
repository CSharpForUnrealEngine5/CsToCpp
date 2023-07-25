#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/ParameterToTransformAdapters.h")]
///<summary>UGizmoAxisScaleParameterSource is an IGizmoFloatParameterSource implementation that</summary>
public partial class UGizmoAxisScaleParameterSource : UGizmoBaseFloatParameterSource {
// GizmoAxisScaleParameterSource
	public object /*AxisSource*/ AxisSource;
	public object /*TransformSource*/ TransformSource;
	public float ScaleMultiplier;
	public bool bClampToZero;
	public float Parameter;
	public FGizmoFloatParameterChange LastChange;
	public FVector CurScaleAxis;
	public FVector CurScaleOrigin;
	public FTransform InitialTransform;
}
