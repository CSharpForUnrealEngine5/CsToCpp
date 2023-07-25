#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VRTool.h")]
///<summary>Base class for virtual production VR tools</summary>
public partial class AVRTool : AVPTransientEditorTickableActorBase {
// VRTool
	public UObject GetInputComponent() { return default; }
	public void SetReceivesEditorInput(bool bInValue) {}
	public bool GetReceivesEditorInput() { return default; }
	public UInputComponent EditorOnlyInputComponent;
	public bool bReceivesEditorInput;
}
