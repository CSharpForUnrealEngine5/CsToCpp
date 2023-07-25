#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/ParameterToTransformAdapters.h")]
///<summary>UGizmoUniformScaleParameterSource is an IGizmoVec2ParameterSource implementation that</summary>
public partial class UGizmoUniformScaleParameterSource : UGizmoBaseVec2ParameterSource {
// GizmoUniformScaleParameterSource
	public object /*AxisSource*/ AxisSource;
	public object /*TransformSource*/ TransformSource;
	public float ScaleMultiplier;
	public FVector2D Parameter;
	public FGizmoVec2ParameterChange LastChange;
	public FVector CurScaleOrigin;
	public FVector CurScaleNormal;
	public FVector CurScaleAxisX;
	public FVector CurScaleAxisY;
	public FTransform InitialTransform;
}
