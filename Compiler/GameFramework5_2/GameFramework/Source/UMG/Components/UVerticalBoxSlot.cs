#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Slot for the UVerticalBox, contains the widget that is flowed vertically</summary>
[CppInclude("Components/VerticalBoxSlot.h")]
public partial class UVerticalBoxSlot : UPanelSlot {
	public static UClass StaticClass() {return default;}
	///<summary>How much space this slot should occupy in the direction of the panel.</summary>
	public FSlateChildSize Size;
	///<summary>The padding area between the slot and the content it contains.</summary>
	public FMargin Padding;
	///<summary>The alignment of the object horizontally.</summary>
	public EHorizontalAlignment HorizontalAlignment;
	///<summary>The alignment of the object vertically.</summary>
	public EVerticalAlignment VerticalAlignment;
	///<summary>SetPadding</summary>
	public  void SetPadding(FMargin InPadding) {}
	///<summary>SetSize</summary>
	public  void SetSize(FSlateChildSize InSize) {}
	///<summary>SetHorizontalAlignment</summary>
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	///<summary>SetVerticalAlignment</summary>
	public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
}
