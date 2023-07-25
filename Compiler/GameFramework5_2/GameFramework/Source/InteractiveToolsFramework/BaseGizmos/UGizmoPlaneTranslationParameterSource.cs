#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/ParameterToTransformAdapters.h")]
///<summary>UGizmoAxisRotationParameterSource is an IGizmoVec2ParameterSource implementation that</summary>
public partial class UGizmoPlaneTranslationParameterSource : UGizmoBaseVec2ParameterSource {
// GizmoPlaneTranslationParameterSource
	public object /*AxisSource*/ AxisSource;
	public object /*TransformSource*/ TransformSource;
	public FVector2D Parameter;
	public FGizmoVec2ParameterChange LastChange;
	public FVector CurTranslationOrigin;
	public FVector CurTranslationNormal;
	public FVector CurTranslationAxisX;
	public FVector CurTranslationAxisY;
	public FTransform InitialTransform;
}
