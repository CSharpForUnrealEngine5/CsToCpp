namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Slot for the UBorderSlot, contains the widget displayed in a border&#39;s single slot</summary>
[CppInclude("Components/BorderSlot.h")]
public partial class UBorderSlot : UPanelSlot {
	public static UClass StaticClass() {return default;}
	///<summary>SetPadding</summary>
	public void SetPadding(FMargin InPadding) {}
	///<summary>SetHorizontalAlignment</summary>
	public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	///<summary>SetVerticalAlignment</summary>
	public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
	///<summary>The padding area between the slot and the content it contains.</summary>
	public FMargin Padding;
	///<summary>The alignment of the object horizontally.</summary>
	public EHorizontalAlignment HorizontalAlignment;
	///<summary>The alignment of the object vertically.</summary>
	public EVerticalAlignment VerticalAlignment;
}
