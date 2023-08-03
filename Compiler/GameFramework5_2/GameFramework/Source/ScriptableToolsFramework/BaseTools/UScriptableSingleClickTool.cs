#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UScriptableSingleClickTool is an extension of UScriptableInteractiveTool that supports</summary>
[CppInclude("BaseTools/ScriptableSingleClickTool.h")]
public partial class UScriptableSingleClickTool : UScriptableInteractiveTool {
	public static UClass StaticClass() {return default;}
	///<summary>Enable Hover support API functions OnHoverHitTest / OnHoverBegin / OnHoverUpdate / OnHoverEnd for Mouse devices.</summary>
	public bool bWantMouseHover;
	///<summary>TestIfHitByClick is called to allow the Tool to indicate if it would like to consume a potential click at ClickPos.</summary>
	public  FInputRayHit TestIfHitByClick(FInputDeviceRay ClickPos,FScriptableToolModifierStates Modifiers) { return default; }
	///<summary>OnHitByClick is called when the Tool has indicated it would like to consume a click event (via TestIfHitByClick), and the click was not cancelled</summary>
	public  void OnHitByClick(FInputDeviceRay ClickPos,FScriptableToolModifierStates Modifiers) {}
	///<summary>OnHoverHitTest is called to allow the Tool to indicate if it would like to start consuing &quot;hover&quot; input at HoverPos.</summary>
	public  FInputRayHit OnHoverHitTest(FInputDeviceRay HoverPos,FScriptableToolModifierStates Modifiers) { return default; }
	///<summary>Begin a sequence of Hover input events</summary>
	public  void OnHoverBegin(FInputDeviceRay HoverPos,FScriptableToolModifierStates Modifiers) {}
	///<summary>Update an active Hover sequence. OnHoverUpdate is only ever called between OnHoverBegin and OnHoverEnd</summary>
	public  bool OnHoverUpdate(FInputDeviceRay HoverPos,FScriptableToolModifierStates Modifiers) { return default; }
	///<summary>Indicate that an active captured Hover sequence has ended. The device may no longer be in the viewport, so no position can be provided.</summary>
	public  void OnHoverEnd(FScriptableToolModifierStates Modifiers) {}
	///<summary>InActiveHover</summary>
	public  bool InActiveHover() { return default; }
	///<summary>@return true if the Shift key is currently held down</summary>
	public  bool IsShiftDown() { return default; }
	///<summary>@return true if the Ctrl key is currently held down</summary>
	public  bool IsCtrlDown() { return default; }
	///<summary>@return true if the Alt key is currently held down</summary>
	public  bool IsAltDown() { return default; }
	///<summary>@return a struct containing the current Modifier key states</summary>
	public  FScriptableToolModifierStates GetActiveModifiers() { return default; }
	///<summary>SingleClickBehavior</summary>
	public USingleClickInputBehavior SingleClickBehavior;
	///<summary>MouseHoverBehavior</summary>
	public UMouseHoverBehavior MouseHoverBehavior;
}
