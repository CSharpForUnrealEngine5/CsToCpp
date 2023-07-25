#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/CombinedTransformGizmo.h")]
///<summary>ACombinedTransformGizmoActor is an Actor type intended to be used with UCombinedTransformGizmo,</summary>
public partial class ACombinedTransformGizmoActor : AGizmoActor {
// CombinedTransformGizmoActor
	public UPrimitiveComponent TranslateX;
	public UPrimitiveComponent TranslateY;
	public UPrimitiveComponent TranslateZ;
	public UPrimitiveComponent TranslateYZ;
	public UPrimitiveComponent TranslateXZ;
	public UPrimitiveComponent TranslateXY;
	public UPrimitiveComponent RotateX;
	public UPrimitiveComponent RotateY;
	public UPrimitiveComponent RotateZ;
	public UPrimitiveComponent RotationSphere;
	public UPrimitiveComponent UniformScale;
	public UPrimitiveComponent AxisScaleX;
	public UPrimitiveComponent AxisScaleY;
	public UPrimitiveComponent AxisScaleZ;
	public UPrimitiveComponent PlaneScaleYZ;
	public UPrimitiveComponent PlaneScaleXZ;
	public UPrimitiveComponent PlaneScaleXY;
}
