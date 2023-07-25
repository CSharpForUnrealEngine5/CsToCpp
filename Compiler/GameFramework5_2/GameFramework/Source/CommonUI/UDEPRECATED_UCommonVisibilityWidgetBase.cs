#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonVisibilityWidgetBase.h")]
///<summary>A container that controls visibility based on Input type and Platform</summary>
public partial class UDEPRECATED_UCommonVisibilityWidgetBase : UCommonBorder {
// UCommonVisibilityWidgetBase
	public TMap<string,bool> VisibilityControls;
	public bool bShowForGamepad;
	public bool bShowForMouseAndKeyboard;
	public bool bShowForTouch;
	public ESlateVisibility VisibleType;
	public ESlateVisibility HiddenType;
	public TArray<string> GetRegisteredPlatforms() { return default; }
}
