namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Slot for the UWrapBox, contains the widget that is flowed vertically</summary>
[CppInclude("Components/WrapBoxSlot.h")]
public partial class UWrapBoxSlot : UPanelSlot {
	public static UClass StaticClass() {return default;}
	///<summary>The padding area between the slot and the content it contains.</summary>
	public FMargin Padding;
	///<summary>If the total available space in the wrap panel drops below this threshold, this slot will attempt to fill an entire line.</summary>
	public float FillSpanWhenLessThan;
	///<summary>The alignment of the object horizontally.</summary>
	public EHorizontalAlignment HorizontalAlignment;
	///<summary>The alignment of the object vertically.</summary>
	public EVerticalAlignment VerticalAlignment;
	///<summary>Should this slot fill the remaining space on the line?</summary>
	public bool bFillEmptySpace;
	///<summary>Should this slot start on a new line?</summary>
	public bool bForceNewLine;
	///<summary>SetPadding</summary>
	public void SetPadding(FMargin InPadding) {}
	///<summary>SetFillEmptySpace</summary>
	public void SetFillEmptySpace(bool InbFillEmptySpace) {}
	///<summary>SetFillSpanWhenLessThan</summary>
	public void SetFillSpanWhenLessThan(float InFillSpanWhenLessThan) {}
	///<summary>SetHorizontalAlignment</summary>
	public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	///<summary>SetVerticalAlignment</summary>
	public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
	///<summary>SetNewLine</summary>
	public void SetNewLine(bool InForceNewLine) {}
}
