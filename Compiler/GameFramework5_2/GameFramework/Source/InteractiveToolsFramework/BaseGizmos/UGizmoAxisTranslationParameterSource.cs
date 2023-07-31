#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGizmoAxisTranslationParameterSource is an IGizmoFloatParameterSource implementation that</summary>
[CppInclude("BaseGizmos/ParameterToTransformAdapters.h")]
public partial class UGizmoAxisTranslationParameterSource : UGizmoBaseFloatParameterSource {
	///<summary>The Parameter line-equation value is converted to a 3D Translation along this Axis</summary>
	public object /*AxisSource*/ AxisSource;
	///<summary>This TransformSource is updated by applying the constructed 3D translation</summary>
	public object /*TransformSource*/ TransformSource;
	///<summary>Parameter is the line-equation parameter that this FloatParameterSource provides</summary>
	public float Parameter;
	///<summary>Active parameter change (only valid between BeginModify/EndModify)</summary>
	public FGizmoFloatParameterChange LastChange;
	///<summary>tranlsation axis for current parameter edit (only valid between BeginModify/EndModify)</summary>
	public FVector CurTranslationAxis;
	///<summary>tranlsation origin for current parameter edit (only valid between BeginModify/EndModify)</summary>
	public FVector CurTranslationOrigin;
	///<summary>Saved copy of Initial Transform for current parameter edit (only valid between BeginModify/EndModify)</summary>
	public FTransform InitialTransform;
}
