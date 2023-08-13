namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Gizmo types should be registered in either UEditorInteractiveGizmoSubsystem or</summary>
[CppInclude("EditorInteractiveGizmoRegistry.h")]
public partial class UEditorInteractiveGizmoRegistry : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Current set of Gizmo Builders</summary>
	public TMap<EEditorGizmoCategory,UEditorGizmoRegistryCategoryEntry> GizmoCategoryMap;
}
