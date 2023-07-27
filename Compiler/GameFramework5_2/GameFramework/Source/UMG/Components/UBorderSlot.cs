#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/BorderSlot.h")]
///<summary>The Slot for the UBorderSlot, contains the widget displayed in a border's single slot</summary>
public partial class UBorderSlot : UPanelSlot {
// BorderSlot
	public  void SetPadding(FMargin InPadding) {}
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
	public FMargin Padding;
	public EHorizontalAlignment HorizontalAlignment;
	public EVerticalAlignment VerticalAlignment;
}
