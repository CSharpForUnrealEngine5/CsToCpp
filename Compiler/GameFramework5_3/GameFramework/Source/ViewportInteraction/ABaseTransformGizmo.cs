namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for transform gizmo</summary>
[CppInclude("VIBaseTransformGizmo.h")]
public partial class ABaseTransformGizmo : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Scene component root of this actor</summary>
	public USceneComponent SceneComponent;
	///<summary>All gizmo components</summary>
	public TArray<UGizmoHandleGroup> AllHandleGroups;
	///<summary>Owning object</summary>
	public UViewportWorldInteraction WorldInteraction;
}
