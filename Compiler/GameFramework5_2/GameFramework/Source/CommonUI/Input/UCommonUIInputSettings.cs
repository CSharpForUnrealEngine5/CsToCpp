#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Input/CommonUIInputSettings.h")]
///<summary>Project-wide input settings for UI input actions</summary>
public partial class UCommonUIInputSettings : UObject {
// CommonUIInputSettings
	public bool bLinkCursorToGamepadFocus;
	public int UIActionProcessingPriority;
	public TArray<FUIInputAction> InputActions;
	public TArray<FUIInputAction> ActionOverrides;
	public FCommonAnalogCursorSettings AnalogCursorSettings;
}
