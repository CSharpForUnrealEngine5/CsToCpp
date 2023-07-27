#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/Overlay.h")]
///<summary>Allows widgets to be stacked on top of each other, uses simple flow layout for content on each layer.</summary>
public partial class UOverlay : UPanelWidget {
// Overlay
	public  UOverlaySlot AddChildToOverlay(UWidget Content) { return default; }
	public  bool ReplaceOverlayChildAt(int Index,UWidget Content) { return default; }
}
