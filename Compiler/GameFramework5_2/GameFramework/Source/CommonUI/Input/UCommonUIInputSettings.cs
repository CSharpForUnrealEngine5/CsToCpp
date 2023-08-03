#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Project-wide input settings for UI input actions</summary>
[CppInclude("Input/CommonUIInputSettings.h")]
public partial class UCommonUIInputSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>True to have the mouse pointer automatically moved to the center of whatever widget is currently focused while using a gamepad.</summary>
	public bool bLinkCursorToGamepadFocus;
	///<summary>The input priority of the input components that process UI input actions.</summary>
	public int UIActionProcessingPriority;
	///<summary>All UI input action mappings for the project</summary>
	public TArray<FUIInputAction> InputActions;
	///<summary>Config-only set of input action overrides - if an entry for a given action is both here and in the InputActions array, this entry wins completely.</summary>
	public TArray<FUIInputAction> ActionOverrides;
	///<summary>AnalogCursorSettings</summary>
	public FCommonAnalogCursorSettings AnalogCursorSettings;
}
