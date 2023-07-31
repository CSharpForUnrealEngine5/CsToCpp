#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The InteractiveGizmoSubsystem provides methods for registering and unregistering</summary>
[CppInclude("EditorInteractiveGizmoSubsystem.h")]
public partial class UEditorInteractiveGizmoSubsystem : UEditorSubsystem {
	///<summary>TRS gizmo builder</summary>
	public UInteractiveGizmoBuilder TransformGizmoBuilder;
	///<summary>Actual registry</summary>
	public UEditorInteractiveGizmoRegistry Registry;
}
