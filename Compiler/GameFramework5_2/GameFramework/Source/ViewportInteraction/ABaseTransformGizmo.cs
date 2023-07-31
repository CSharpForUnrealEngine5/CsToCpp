#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for transform gizmo</summary>
[CppInclude("VIBaseTransformGizmo.h")]
public partial class ABaseTransformGizmo : AActor {
	///<summary>Scene component root of this actor</summary>
	public USceneComponent SceneComponent;
	///<summary>All gizmo components</summary>
	public TArray<UGizmoHandleGroup> AllHandleGroups;
	///<summary>Owning object</summary>
	public UViewportWorldInteraction WorldInteraction;
}
