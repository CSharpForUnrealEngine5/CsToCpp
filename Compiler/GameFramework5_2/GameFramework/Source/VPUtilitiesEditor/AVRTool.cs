namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for virtual production VR tools</summary>
[CppInclude("VRTool.h")]
public partial class AVRTool : AVPTransientEditorTickableActorBase {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the current InputComponent on this utility actor. This will be NULL unless bReceivesEditorInput is set to true.</summary>
	public UInputComponent GetInputComponent() { return default; }
	///<summary>SetReceivesEditorInput</summary>
	public void SetReceivesEditorInput(bool bInValue) {}
	///<summary>GetReceivesEditorInput</summary>
	public bool GetReceivesEditorInput() { return default; }
	///<summary>EditorOnlyInputComponent</summary>
	public UInputComponent EditorOnlyInputComponent;
	///<summary>If set to true, then this actor will be able to recieve input delegate callbacks when in the editor.</summary>
	public bool bReceivesEditorInput;
}
