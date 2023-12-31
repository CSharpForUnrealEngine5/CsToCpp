namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Virtually identical to a UBorderSlot, but unfortunately that assumes (fairly) that its parent widget is a UBorder.</summary>
[CppInclude("CommonLoadGuard.h")]
public partial class ULoadGuardSlot : UPanelSlot {
	public static UClass StaticClass() {return default;}
	///<summary>SetPadding</summary>
	public void SetPadding(FMargin InPadding) {}
	///<summary>SetHorizontalAlignment</summary>
	public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	///<summary>SetVerticalAlignment</summary>
	public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
	///<summary>Padding</summary>
	public FMargin Padding;
	///<summary>HorizontalAlignment</summary>
	public EHorizontalAlignment HorizontalAlignment;
	///<summary>VerticalAlignment</summary>
	public EVerticalAlignment VerticalAlignment;
}
