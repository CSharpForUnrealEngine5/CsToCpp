namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Input Config that can be applied on widget activation. Allows for input setup  (Mouse capture,</summary>
[CppInclude("Input/UIActionBindingHandle.h")]
public partial struct FUIInputConfig {
	public bool bIgnoreMoveInput;
	public bool bIgnoreLookInput;
	public ECommonInputMode InputMode;
	public EMouseCaptureMode MouseCaptureMode;
	public bool bHideCursorDuringViewportCapture;
}
