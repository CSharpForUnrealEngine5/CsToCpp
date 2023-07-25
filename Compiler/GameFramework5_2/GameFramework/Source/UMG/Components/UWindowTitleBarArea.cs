#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/WindowTitleBarArea.h")]
///<summary>A panel for defining a region of the UI that should allow users to drag the window on desktop platforms.</summary>
public partial class UWindowTitleBarArea : UContentWidget {
// WindowTitleBarArea
	public bool bWindowButtonsEnabled;
	public bool bDoubleClickTogglesFullscreen;
	public void SetPadding(FMargin InPadding) {}
	public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
}
