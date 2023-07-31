#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Slot for the UWindowTitleBarArea</summary>
[CppInclude("Components/WindowTitleBarAreaSlot.h")]
public partial class UWindowTitleBarAreaSlot : UPanelSlot {
	///<summary>SetPadding</summary>
	public  void SetPadding(FMargin InPadding) {}
	///<summary>SetHorizontalAlignment</summary>
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	///<summary>SetVerticalAlignment</summary>
	public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
	///<summary>The padding area between the slot and the content it contains.</summary>
	public FMargin Padding;
	///<summary>The alignment of the object horizontally.</summary>
	public EHorizontalAlignment HorizontalAlignment;
	///<summary>The alignment of the object vertically.</summary>
	public EVerticalAlignment VerticalAlignment;
}
