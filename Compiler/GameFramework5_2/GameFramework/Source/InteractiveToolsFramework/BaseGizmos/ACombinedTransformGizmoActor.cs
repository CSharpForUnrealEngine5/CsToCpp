#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ACombinedTransformGizmoActor is an Actor type intended to be used with UCombinedTransformGizmo,</summary>
[CppInclude("BaseGizmos/CombinedTransformGizmo.h")]
public partial class ACombinedTransformGizmoActor : AGizmoActor {
	public static UClass StaticClass() {return default;}
	///<summary>X Axis Translation Component</summary>
	public UPrimitiveComponent TranslateX;
	///<summary>Y Axis Translation Component</summary>
	public UPrimitiveComponent TranslateY;
	///<summary>Z Axis Translation Component</summary>
	public UPrimitiveComponent TranslateZ;
	///<summary>YZ Plane Translation Component</summary>
	public UPrimitiveComponent TranslateYZ;
	///<summary>XZ Plane Translation Component</summary>
	public UPrimitiveComponent TranslateXZ;
	///<summary>XY Plane Translation Component</summary>
	public UPrimitiveComponent TranslateXY;
	///<summary>X Axis Rotation Component</summary>
	public UPrimitiveComponent RotateX;
	///<summary>Y Axis Rotation Component</summary>
	public UPrimitiveComponent RotateY;
	///<summary>Z Axis Rotation Component</summary>
	public UPrimitiveComponent RotateZ;
	///<summary>Z Axis Rotation Component</summary>
	public UPrimitiveComponent RotationSphere;
	///<summary>Uniform Scale Component</summary>
	public UPrimitiveComponent UniformScale;
	///<summary>X Axis Scale Component</summary>
	public UPrimitiveComponent AxisScaleX;
	///<summary>Y Axis Scale Component</summary>
	public UPrimitiveComponent AxisScaleY;
	///<summary>Z Axis Scale Component</summary>
	public UPrimitiveComponent AxisScaleZ;
	///<summary>YZ Plane Scale Component</summary>
	public UPrimitiveComponent PlaneScaleYZ;
	///<summary>XZ Plane Scale Component</summary>
	public UPrimitiveComponent PlaneScaleXZ;
	///<summary>XY Plane Scale Component</summary>
	public UPrimitiveComponent PlaneScaleXY;
}
