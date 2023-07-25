#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Gizmo/VIPivotTransformGizmo.h")]
///<summary>A transform gizmo on the pivot that allows you to interact with selected objects by moving, scaling and rotating.</summary>
public partial class APivotTransformGizmo : ABaseTransformGizmo {
// PivotTransformGizmo
	public UUniformScaleGizmoHandleGroup UniformScaleGizmoHandleGroup;
	public UPivotTranslationGizmoHandleGroup TranslationGizmoHandleGroup;
	public UPivotScaleGizmoHandleGroup ScaleGizmoHandleGroup;
	public UPivotPlaneTranslationGizmoHandleGroup PlaneTranslationGizmoHandleGroup;
	public UPivotRotationGizmoHandleGroup RotationGizmoHandleGroup;
	public UStretchGizmoHandleGroup StretchGizmoHandleGroup;
	public UActorComponent LastDraggingHandle;
}
