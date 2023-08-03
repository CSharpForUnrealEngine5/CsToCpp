#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGizmoAxisRotationParameterSource is an IGizmoVec2ParameterSource implementation that</summary>
[CppInclude("BaseGizmos/ParameterToTransformAdapters.h")]
public partial class UGizmoPlaneTranslationParameterSource : UGizmoBaseVec2ParameterSource {
	public static UClass StaticClass() {return default;}
	///<summary>AxisSource provides the 3D plane (origin/normal/u/v) that is used to interpret the 2D parameters</summary>
	public object /*AxisSource*/ AxisSource;
	///<summary>This TransformSource is updated by applying the constructed 3D translation</summary>
	public object /*TransformSource*/ TransformSource;
	///<summary>Parameter is the two line-equation parameters that this Vec2ParameterSource provides</summary>
	public FVector2D Parameter;
	///<summary>Active parameter change (only valid between BeginModify/EndModify)</summary>
	public FGizmoVec2ParameterChange LastChange;
	///<summary>plane origin for current parameter edit (only valid between BeginModify/EndModify)</summary>
	public FVector CurTranslationOrigin;
	///<summary>plane normal for current parameter edit (only valid between BeginModify/EndModify)</summary>
	public FVector CurTranslationNormal;
	///<summary>in-plane axis X for current parameter edit (only valid between BeginModify/EndModify)</summary>
	public FVector CurTranslationAxisX;
	///<summary>in-plane axis Y for current parameter edit (only valid between BeginModify/EndModify)</summary>
	public FVector CurTranslationAxisY;
	///<summary>Saved copy of Initial Transform for current parameter edit (only valid between BeginModify/EndModify)</summary>
	public FTransform InitialTransform;
}
