#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A transform gizmo on the pivot that allows you to interact with selected objects by moving, scaling and rotating.</summary>
[CppInclude("Gizmo/VIPivotTransformGizmo.h")]
public partial class APivotTransformGizmo : ABaseTransformGizmo {
	///<summary>Uniform scale handle group component</summary>
	public UUniformScaleGizmoHandleGroup UniformScaleGizmoHandleGroup;
	///<summary>Translation handle group component</summary>
	public UPivotTranslationGizmoHandleGroup TranslationGizmoHandleGroup;
	///<summary>Scale handle group component</summary>
	public UPivotScaleGizmoHandleGroup ScaleGizmoHandleGroup;
	///<summary>Plane translation handle group component</summary>
	public UPivotPlaneTranslationGizmoHandleGroup PlaneTranslationGizmoHandleGroup;
	///<summary>Rotation handle group component</summary>
	public UPivotRotationGizmoHandleGroup RotationGizmoHandleGroup;
	///<summary>Stretch handle group component</summary>
	public UStretchGizmoHandleGroup StretchGizmoHandleGroup;
	///<summary>Handle from previous tick that was dragged</summary>
	public UActorComponent LastDraggingHandle;
}
