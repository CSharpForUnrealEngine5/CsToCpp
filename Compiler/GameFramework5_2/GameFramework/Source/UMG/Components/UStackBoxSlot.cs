#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Slot for the UStackBox, contains the widget that is flowed vertically or horizontally.</summary>
[CppInclude("Components/StackBoxSlot.h")]
public partial class UStackBoxSlot : UPanelSlot {
	public static UClass StaticClass() {return default;}
	///<summary>The padding area between the slot and the content it contains.</summary>
	public FMargin Padding;
	///<summary>How much space this slot should occupy in the direction of the panel.</summary>
	public FSlateChildSize Size;
	///<summary>The alignment of the object horizontally.</summary>
	public EHorizontalAlignment HorizontalAlignment;
	///<summary>The alignment of the object vertically.</summary>
	public EVerticalAlignment VerticalAlignment;
}
