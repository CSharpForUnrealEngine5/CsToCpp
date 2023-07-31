#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/HorizontalBoxSlot.h")]
public partial class UHorizontalBoxSlot : UPanelSlot {
	///<summary>How much space this slot should occupy in the direction of the panel.</summary>
	public FSlateChildSize Size;
	///<summary>The amount of padding between the slots parent and the content.</summary>
	public FMargin Padding;
	///<summary>HorizontalAlignment</summary>
	public EHorizontalAlignment HorizontalAlignment;
	///<summary>VerticalAlignment</summary>
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
