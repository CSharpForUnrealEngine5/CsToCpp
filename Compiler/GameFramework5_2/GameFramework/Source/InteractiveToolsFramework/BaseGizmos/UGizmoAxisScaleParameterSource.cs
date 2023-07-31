#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGizmoAxisScaleParameterSource is an IGizmoFloatParameterSource implementation that</summary>
[CppInclude("BaseGizmos/ParameterToTransformAdapters.h")]
public partial class UGizmoAxisScaleParameterSource : UGizmoBaseFloatParameterSource {
	///<summary>The Parameter line-equation value is converted to a 3D Translation along this Axis</summary>
	public object /*AxisSource*/ AxisSource;
	///<summary>This TransformSource is updated by applying the constructed 3D rotation</summary>
	public object /*TransformSource*/ TransformSource;
	///<summary>Coordinate delta is multiplied by this amount</summary>
	public float ScaleMultiplier;
	///<summary>If true, the minimal output scale will be zero.</summary>
	public bool bClampToZero;
	///<summary>Parameter is the line-equation parameter that this FloatParameterSource provides</summary>
	public float Parameter;
	///<summary>Active parameter change (only valid between BeginModify/EndModify)</summary>
	public FGizmoFloatParameterChange LastChange;
	///<summary>scale axis for current parameter edit (only valid between BeginModify/EndModify)</summary>
	public FVector CurScaleAxis;
	///<summary>scale origin for current parameter edit (only valid between BeginModify/EndModify)</summary>
	public FVector CurScaleOrigin;
	///<summary>Saved copy of Initial transform for current parameter edit (only valid between BeginModify/EndModify)</summary>
	public FTransform InitialTransform;
}
