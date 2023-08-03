#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Slot for the UScaleBoxSlot, contains the widget displayed in a button&#39;s single slot</summary>
[CppInclude("Components/ScaleBoxSlot.h")]
public partial class UScaleBoxSlot : UPanelSlot {
	public static UClass StaticClass() {return default;}
	///<summary>The padding area between the slot and the content it contains.</summary>
	public FMargin Padding_DEPRECATED;
	///<summary>The alignment of the object horizontally.</summary>
	public EHorizontalAlignment HorizontalAlignment;
	///<summary>The alignment of the object vertically.</summary>
	public EVerticalAlignment VerticalAlignment;
	///<summary>SetPadding</summary>
	public  void SetPadding(FMargin InPadding) {}
	///<summary>SetHorizontalAlignment</summary>
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	///<summary>SetVerticalAlignment</summary>
	public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
}
