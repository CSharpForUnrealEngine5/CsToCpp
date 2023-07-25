#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/WidgetSwitcherSlot.h")]
///<summary>The Slot for the UWidgetSwitcher, contains the widget that is flowed vertically</summary>
public partial class UWidgetSwitcherSlot : UPanelSlot {
// WidgetSwitcherSlot
	public FMargin Padding;
	public byte HorizontalAlignment;
	public byte VerticalAlignment;
	public void SetPadding(FMargin InPadding) {}
	public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
}
