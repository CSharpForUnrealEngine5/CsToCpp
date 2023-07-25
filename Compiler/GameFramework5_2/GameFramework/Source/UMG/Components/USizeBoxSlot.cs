#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SizeBoxSlot.h")]
///<summary>The Slot for the USizeBoxSlot, contains the widget displayed in a button's single slot</summary>
public partial class USizeBoxSlot : UPanelSlot {
// SizeBoxSlot
	public FMargin Padding;
	public byte HorizontalAlignment;
	public byte VerticalAlignment;
	public void SetPadding(FMargin InPadding) {}
	public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
}
