#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/VerticalBoxSlot.h")]
///<summary>The Slot for the UVerticalBox, contains the widget that is flowed vertically</summary>
public partial class UVerticalBoxSlot : UPanelSlot {
// VerticalBoxSlot
	public FSlateChildSize Size;
	public FMargin Padding;
	public byte HorizontalAlignment;
	public byte VerticalAlignment;
	public  void SetPadding(FMargin InPadding) {}
	public  void SetSize(FSlateChildSize InSize) {}
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
}
