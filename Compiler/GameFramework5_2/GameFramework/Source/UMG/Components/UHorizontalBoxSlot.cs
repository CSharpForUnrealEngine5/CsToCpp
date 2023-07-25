#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/HorizontalBoxSlot.h")]
public partial class UHorizontalBoxSlot : UPanelSlot {
// HorizontalBoxSlot
	public FSlateChildSize Size;
	public FMargin Padding;
	public byte HorizontalAlignment;
	public byte VerticalAlignment;
	public void SetPadding(FMargin InPadding) {}
	public void SetSize(FSlateChildSize InSize) {}
	public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
}
