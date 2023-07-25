#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Gizmo/VIPivotTransformGizmo.h")]
///<summary>Axis Gizmo handle for rotation</summary>
public partial class UPivotRotationGizmoHandleGroup : UAxisGizmoHandleGroup {
// PivotRotationGizmoHandleGroup
	public USceneComponent RootFullRotationHandleComponent;
	public UGizmoHandleMeshComponent FullRotationHandleMeshComponent;
	public UGizmoHandleMeshComponent StartRotationIndicatorMeshComponent;
	public USceneComponent RootStartRotationIdicatorComponent;
	public UGizmoHandleMeshComponent DeltaRotationIndicatorMeshComponent;
	public USceneComponent RootDeltaRotationIndicatorComponent;
}
