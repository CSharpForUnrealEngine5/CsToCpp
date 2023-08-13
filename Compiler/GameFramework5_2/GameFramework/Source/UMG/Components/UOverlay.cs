namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows widgets to be stacked on top of each other, uses simple flow layout for content on each layer.</summary>
[CppInclude("Components/Overlay.h")]
public partial class UOverlay : UPanelWidget {
	public static UClass StaticClass() {return default;}
	///<summary>AddChildToOverlay</summary>
	public UOverlaySlot AddChildToOverlay(UWidget Content) { return default; }
	///<summary>Replace the widget at the given index it with a different widget.</summary>
	public bool ReplaceOverlayChildAt(int Index,UWidget Content) { return default; }
}
