namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The InteractiveGizmoSubsystem provides methods for registering and unregistering</summary>
[CppInclude("EditorInteractiveGizmoSubsystem.h")]
public partial class UEditorInteractiveGizmoSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>TRS gizmo builder</summary>
	public UInteractiveGizmoBuilder TransformGizmoBuilder;
	///<summary>Actual registry</summary>
	public UEditorInteractiveGizmoRegistry Registry;
}
