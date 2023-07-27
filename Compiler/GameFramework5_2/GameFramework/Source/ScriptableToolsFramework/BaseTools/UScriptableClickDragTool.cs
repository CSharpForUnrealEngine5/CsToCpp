#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseTools/ScriptableClickDragTool.h")]
///<summary>UScriptableClickDragTool is an extension of UScriptableInteractiveTool that supports</summary>
public partial class UScriptableClickDragTool : UScriptableInteractiveTool {
// ScriptableClickDragTool
	public bool bWantMouseHover;
	public bool bUpdateModifiersDuringDrag;
	public  FInputRayHit TestIfCanBeginClickDrag(FInputDeviceRay ClickPos,FScriptableToolModifierStates Modifiers) { return default; }
	public  void OnDragBegin(FInputDeviceRay StartPosition,FScriptableToolModifierStates Modifiers) {}
	public  void OnDragUpdatePosition(FInputDeviceRay NewPosition,FScriptableToolModifierStates Modifiers) {}
	public  void OnDragEnd(FInputDeviceRay EndPosition,FScriptableToolModifierStates Modifiers) {}
	public  void OnDragSequenceCancelled() {}
	public  bool InActiveClickDrag() { return default; }
	public  FInputRayHit OnHoverHitTest(FInputDeviceRay HoverPos,FScriptableToolModifierStates Modifiers) { return default; }
	public  void OnHoverBegin(FInputDeviceRay HoverPos,FScriptableToolModifierStates Modifiers) {}
	public  bool OnHoverUpdate(FInputDeviceRay HoverPos,FScriptableToolModifierStates Modifiers) { return default; }
	public  void OnHoverEnd(FScriptableToolModifierStates Modifiers) {}
	public  bool InActiveHover() { return default; }
	public  bool IsShiftDown() { return default; }
	public  bool IsCtrlDown() { return default; }
	public  bool IsAltDown() { return default; }
	public  FScriptableToolModifierStates GetActiveModifiers() { return default; }
	public UClickDragInputBehavior ClickDragBehavior;
	public UMouseHoverBehavior MouseHoverBehavior;
}
