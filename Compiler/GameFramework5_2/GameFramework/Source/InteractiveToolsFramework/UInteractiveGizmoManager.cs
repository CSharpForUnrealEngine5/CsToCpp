#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InteractiveGizmoManager.h")]
///<summary>UInteractiveGizmoManager allows users of the Tools framework to create and operate Gizmo instances.</summary>
public partial class UInteractiveGizmoManager : UObject {
// InteractiveGizmoManager
	public TArray<FActiveGizmo> ActiveGizmos;
	public TMap<string,UInteractiveGizmoBuilder> GizmoBuilders;
}
