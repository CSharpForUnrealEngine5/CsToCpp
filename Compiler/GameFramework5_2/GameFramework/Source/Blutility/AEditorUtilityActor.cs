#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorUtilityActor.h")]
public partial class AEditorUtilityActor : AActor {
// EditorUtilityActor
	public void Run() {}
	public UObject GetInputComponent() { return default; }
	public void SetReceivesEditorInput(bool bInValue) {}
	public bool GetReceivesEditorInput() { return default; }
	public UInputComponent EditorOnlyInputComponent;
	public bool bReceivesEditorInput;
}
