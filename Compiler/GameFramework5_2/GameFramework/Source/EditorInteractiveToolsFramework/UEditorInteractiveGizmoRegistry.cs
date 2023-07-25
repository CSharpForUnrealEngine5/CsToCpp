#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorInteractiveGizmoRegistry.h")]
///<summary>Gizmo types should be registered in either UEditorInteractiveGizmoSubsystem or</summary>
public partial class UEditorInteractiveGizmoRegistry : UObject {
// EditorInteractiveGizmoRegistry
	public TMap<EEditorGizmoCategory,UEditorGizmoRegistryCategoryEntry> GizmoCategoryMap;
}
