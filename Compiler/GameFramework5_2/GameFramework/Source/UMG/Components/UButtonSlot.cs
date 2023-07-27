#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ButtonSlot.h")]
///<summary>The Slot for the UButtonSlot, contains the widget displayed in a button's single slot</summary>
public partial class UButtonSlot : UPanelSlot {
// ButtonSlot
	public FMargin Padding;
	public EHorizontalAlignment HorizontalAlignment;
	public EVerticalAlignment VerticalAlignment;
	public  void SetPadding(FMargin InPadding) {}
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
}
