#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/OverlaySlot.h")]
///<summary>Slot for the UOverlay panel.  Allows content to be hover above other content.</summary>
public partial class UOverlaySlot : UPanelSlot {
// OverlaySlot
	public FMargin Padding;
	public byte HorizontalAlignment;
	public byte VerticalAlignment;
	public void SetPadding(FMargin InPadding) {}
	public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
}
