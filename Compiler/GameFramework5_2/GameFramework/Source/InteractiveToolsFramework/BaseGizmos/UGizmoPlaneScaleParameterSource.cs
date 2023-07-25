#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/ParameterToTransformAdapters.h")]
///<summary>UGizmoPlaneScaleParameterSource  is an UGizmoBaseVec2ParameterSource implementation that</summary>
public partial class UGizmoPlaneScaleParameterSource : UGizmoBaseVec2ParameterSource {
// GizmoPlaneScaleParameterSource
	public object /*AxisSource*/ AxisSource;
	public object /*TransformSource*/ TransformSource;
	public float ScaleMultiplier;
	public bool bUseEqualScaling;
	public bool bClampToZero;
	public FVector2D Parameter;
	public FGizmoVec2ParameterChange LastChange;
	public FVector CurScaleOrigin;
	public FVector CurScaleNormal;
	public FVector CurScaleAxisX;
	public FVector CurScaleAxisY;
	public FTransform InitialTransform;
}
