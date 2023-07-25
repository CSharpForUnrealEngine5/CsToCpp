#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/ParameterToTransformAdapters.h")]
///<summary>UGizmoAxisTranslationParameterSource is an IGizmoFloatParameterSource implementation that</summary>
public partial class UGizmoAxisTranslationParameterSource : UGizmoBaseFloatParameterSource {
// GizmoAxisTranslationParameterSource
	public object /*AxisSource*/ AxisSource;
	public object /*TransformSource*/ TransformSource;
	public float Parameter;
	public FGizmoFloatParameterChange LastChange;
	public FVector CurTranslationAxis;
	public FVector CurTranslationOrigin;
	public FTransform InitialTransform;
}
