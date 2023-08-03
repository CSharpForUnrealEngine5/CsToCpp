#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Slot for the UOverlay panel.  Allows content to be hover above other content.</summary>
[CppInclude("Components/OverlaySlot.h")]
public partial class UOverlaySlot : UPanelSlot {
	public static UClass StaticClass() {return default;}
	///<summary>The padding area between the slot and the content it contains.</summary>
	public FMargin Padding;
	///<summary>The alignment of the object horizontally.</summary>
	public EHorizontalAlignment HorizontalAlignment;
	///<summary>The alignment of the object vertically.</summary>
	public EVerticalAlignment VerticalAlignment;
	///<summary>Set padding area between the slot and the content it contains.</summary>
	public  void SetPadding(FMargin InPadding) {}
	///<summary>Set the alignment of the object horizontally.</summary>
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	///<summary>Set the alignment of the object vertically.</summary>
	public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
}
