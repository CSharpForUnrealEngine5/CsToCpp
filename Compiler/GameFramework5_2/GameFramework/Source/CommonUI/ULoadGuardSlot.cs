#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonLoadGuard.h")]
///<summary>Virtually identical to a UBorderSlot, but unfortunately that assumes (fairly) that its parent widget is a UBorder.</summary>
public partial class ULoadGuardSlot : UPanelSlot {
// LoadGuardSlot
	public void SetPadding(FMargin InPadding) {}
	public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
	public FMargin Padding;
	public byte HorizontalAlignment;
	public byte VerticalAlignment;
}
