#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/BackgroundBlurSlot.h")]
///<summary>The Slot for the UBackgroundBlurSlot, contains the widget displayed in a BackgroundBlur's single slot</summary>
public partial class UBackgroundBlurSlot : UPanelSlot {
// BackgroundBlurSlot
	public  void SetPadding(FMargin InPadding) {}
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
	public FMargin Padding;
	public byte HorizontalAlignment;
	public byte VerticalAlignment;
}
