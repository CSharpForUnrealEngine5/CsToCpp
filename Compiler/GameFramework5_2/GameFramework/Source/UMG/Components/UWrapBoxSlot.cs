#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/WrapBoxSlot.h")]
///<summary>The Slot for the UWrapBox, contains the widget that is flowed vertically</summary>
public partial class UWrapBoxSlot : UPanelSlot {
// WrapBoxSlot
	public FMargin Padding;
	public float FillSpanWhenLessThan;
	public byte HorizontalAlignment;
	public byte VerticalAlignment;
	public bool bFillEmptySpace;
	public bool bForceNewLine;
	public  void SetPadding(FMargin InPadding) {}
	public  void SetFillEmptySpace(bool InbFillEmptySpace) {}
	public  void SetFillSpanWhenLessThan(float InFillSpanWhenLessThan) {}
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
	public  void SetNewLine(bool InForceNewLine) {}
}
