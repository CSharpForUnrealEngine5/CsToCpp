#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGizmoAxisRotationParameterSource is an IGizmoFloatParameterSource implementation that</summary>
[CppInclude("BaseGizmos/ParameterToTransformAdapters.h")]
public partial class UGizmoAxisRotationParameterSource : UGizmoBaseFloatParameterSource {
	public static UClass StaticClass() {return default;}
	///<summary>float-parameter Angle is mapped to a 3D Rotation around this Axis</summary>
	public object /*AxisSource*/ AxisSource;
	///<summary>This TransformSource is updated by applying the constructed 3D rotation</summary>
	public object /*TransformSource*/ TransformSource;
	///<summary>Angle is the parameter that this FloatParameterSource provides</summary>
	public float Angle;
	///<summary>Active parameter change (only valid between BeginModify/EndModify)</summary>
	public FGizmoFloatParameterChange LastChange;
	///<summary>Rotation axis for current parameter edit (only valid between BeginModify/EndModify)</summary>
	public FVector CurRotationAxis;
	///<summary>Rotation origin for current parameter edit (only valid between BeginModify/EndModify)</summary>
	public FVector CurRotationOrigin;
	///<summary>Saved copy of Initial Transform for current parameter edit (only valid between BeginModify/EndModify)</summary>
	public FTransform InitialTransform;
}
