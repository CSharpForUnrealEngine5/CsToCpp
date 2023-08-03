#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A panel for defining a region of the UI that should allow users to drag the window on desktop platforms.</summary>
[CppInclude("Components/WindowTitleBarArea.h")]
public partial class UWindowTitleBarArea : UContentWidget {
	public static UClass StaticClass() {return default;}
	///<summary>Should the title bar area diaplay window minimize/maximize/close buttons.</summary>
	public bool bWindowButtonsEnabled;
	///<summary>Should double clicking the title bar area toggle fullscreen instead of maximizing the window.</summary>
	public bool bDoubleClickTogglesFullscreen;
	///<summary>SetPadding</summary>
	public  void SetPadding(FMargin InPadding) {}
	///<summary>SetHorizontalAlignment</summary>
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	///<summary>SetVerticalAlignment</summary>
	public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
}
