#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Axis Gizmo handle for rotation</summary>
[CppInclude("Gizmo/VIPivotTransformGizmo.h")]
public partial class UPivotRotationGizmoHandleGroup : UAxisGizmoHandleGroup {
	public static UClass StaticClass() {return default;}
	///<summary>Root component of all the mesh components that are used to visualize the rotation when dragging</summary>
	public USceneComponent RootFullRotationHandleComponent;
	///<summary>When dragging a rotation handle the full rotation circle appears</summary>
	public UGizmoHandleMeshComponent FullRotationHandleMeshComponent;
	///<summary>The mesh that indicated the start rotation</summary>
	public UGizmoHandleMeshComponent StartRotationIndicatorMeshComponent;
	///<summary>The root component of the start rotation indicator</summary>
	public USceneComponent RootStartRotationIdicatorComponent;
	///<summary>The mesh that indicated the delta rotation</summary>
	public UGizmoHandleMeshComponent DeltaRotationIndicatorMeshComponent;
	///<summary>The root component of the delta rotation indicator</summary>
	public USceneComponent RootDeltaRotationIndicatorComponent;
}
