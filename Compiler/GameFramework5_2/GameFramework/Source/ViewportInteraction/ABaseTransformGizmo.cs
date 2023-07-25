#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VIBaseTransformGizmo.h")]
///<summary>Base class for transform gizmo</summary>
public partial class ABaseTransformGizmo : AActor {
// BaseTransformGizmo
	public USceneComponent SceneComponent;
	public TArray<UGizmoHandleGroup> AllHandleGroups;
	public UViewportWorldInteraction WorldInteraction;
}
