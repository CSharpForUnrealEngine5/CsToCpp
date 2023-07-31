#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Gizmo types should be registered in either UEditorInteractiveGizmoSubsystem or</summary>
[CppInclude("EditorInteractiveGizmoRegistry.h")]
public partial class UEditorInteractiveGizmoRegistry : UObject {
	///<summary>Current set of Gizmo Builders</summary>
	public TMap<EEditorGizmoCategory,UEditorGizmoRegistryCategoryEntry> GizmoCategoryMap;
}
