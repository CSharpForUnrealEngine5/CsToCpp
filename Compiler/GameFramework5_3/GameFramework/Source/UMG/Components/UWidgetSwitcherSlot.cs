namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Slot for the UWidgetSwitcher, contains the widget that is flowed vertically</summary>
[CppInclude("Components/WidgetSwitcherSlot.h")]
public partial class UWidgetSwitcherSlot : UPanelSlot {
	public static UClass StaticClass() {return default;}
	///<summary>The padding area between the slot and the content it contains.</summary>
	public FMargin Padding;
	///<summary>The alignment of the object horizontally.</summary>
	public EHorizontalAlignment HorizontalAlignment;
	///<summary>The alignment of the object vertically.</summary>
	public EVerticalAlignment VerticalAlignment;
	///<summary>SetPadding</summary>
	public void SetPadding(FMargin InPadding) {}
	///<summary>SetHorizontalAlignment</summary>
	public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	///<summary>SetVerticalAlignment</summary>
	public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
}
