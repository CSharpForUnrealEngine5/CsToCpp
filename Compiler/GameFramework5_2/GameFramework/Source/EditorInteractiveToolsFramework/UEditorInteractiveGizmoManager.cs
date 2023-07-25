#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorInteractiveGizmoManager.h")]
///<summary>UEditorInteractiveGizmoManager allows users of the Tools framework to register and create selection-based Gizmo instances.</summary>
public partial class UEditorInteractiveGizmoManager : UInteractiveGizmoManager {
// EditorInteractiveGizmoManager
	public UEditorInteractiveGizmoRegistry Registry;
	public TArray<FActiveEditorGizmo> ActiveEditorGizmos;
	public TMap<UInteractiveGizmoBuilder,UInteractiveGizmo> CachedGizmoMap;
}
