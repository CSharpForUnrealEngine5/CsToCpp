#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ScaleBoxSlot.h")]
///<summary>The Slot for the UScaleBoxSlot, contains the widget displayed in a button's single slot</summary>
public partial class UScaleBoxSlot : UPanelSlot {
// ScaleBoxSlot
	public FMargin Padding_DEPRECATED;
	public byte HorizontalAlignment;
	public byte VerticalAlignment;
	public void SetPadding(FMargin InPadding) {}
	public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
}
