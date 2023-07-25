#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseTools/ScriptableSingleClickTool.h")]
///<summary>UScriptableSingleClickTool is an extension of UScriptableInteractiveTool that supports</summary>
public partial class UScriptableSingleClickTool : UScriptableInteractiveTool {
// ScriptableSingleClickTool
	public bool bWantMouseHover;
	public FInputRayHit TestIfHitByClick(FInputDeviceRay ClickPos,FScriptableToolModifierStates Modifiers) { return default; }
	public void OnHitByClick(FInputDeviceRay ClickPos,FScriptableToolModifierStates Modifiers) {}
	public FInputRayHit OnHoverHitTest(FInputDeviceRay HoverPos,FScriptableToolModifierStates Modifiers) { return default; }
	public void OnHoverBegin(FInputDeviceRay HoverPos,FScriptableToolModifierStates Modifiers) {}
	public bool OnHoverUpdate(FInputDeviceRay HoverPos,FScriptableToolModifierStates Modifiers) { return default; }
	public void OnHoverEnd(FScriptableToolModifierStates Modifiers) {}
	public bool InActiveHover() { return default; }
	public bool IsShiftDown() { return default; }
	public bool IsCtrlDown() { return default; }
	public bool IsAltDown() { return default; }
	public FScriptableToolModifierStates GetActiveModifiers() { return default; }
	public USingleClickInputBehavior SingleClickBehavior;
	public UMouseHoverBehavior MouseHoverBehavior;
}
