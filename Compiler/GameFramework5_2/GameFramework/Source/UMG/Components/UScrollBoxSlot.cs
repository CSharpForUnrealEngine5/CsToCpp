#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ScrollBoxSlot.h")]
///<summary>The Slot for the UScrollBox, contains the widget that are scrollable</summary>
public partial class UScrollBoxSlot : UPanelSlot {
// ScrollBoxSlot
	public FSlateChildSize Size;
	public FMargin Padding;
	public EHorizontalAlignment HorizontalAlignment;
	public EVerticalAlignment VerticalAlignment;
	public  void SetPadding(FMargin InPadding) {}
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
}
