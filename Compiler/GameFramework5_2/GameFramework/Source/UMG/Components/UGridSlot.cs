#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A slot for UGridPanel, these slots all share the same size as the largest slot</summary>
[CppInclude("Components/GridSlot.h")]
public partial class UGridSlot : UPanelSlot {
	public static UClass StaticClass() {return default;}
	///<summary>The padding area between the slot and the content it contains.</summary>
	public FMargin Padding;
	///<summary>The alignment of the object horizontally.</summary>
	public EHorizontalAlignment HorizontalAlignment;
	///<summary>The alignment of the object vertically.</summary>
	public EVerticalAlignment VerticalAlignment;
	///<summary>The row index of the cell this slot is in</summary>
	public int Row;
	///<summary>RowSpan</summary>
	public int RowSpan;
	///<summary>The column index of the cell this slot is in</summary>
	public int Column;
	///<summary>ColumnSpan</summary>
	public int ColumnSpan;
	///<summary>Positive values offset this cell to be hit-tested and drawn on top of others. Default is 0; i.e. no offset.</summary>
	public int Layer;
	///<summary>Offset this slot&#39;s content by some amount; positive values offset to lower right</summary>
	public FVector2D Nudge;
	///<summary>SetPadding</summary>
	public  void SetPadding(FMargin InPadding) {}
	///<summary>Sets the row index of the slot, this determines what cell the slot is in the panel</summary>
	public  void SetRow(int InRow) {}
	///<summary>How many rows this this slot spans over</summary>
	public  void SetRowSpan(int InRowSpan) {}
	///<summary>Sets the column index of the slot, this determines what cell the slot is in the panel</summary>
	public  void SetColumn(int InColumn) {}
	///<summary>How many columns this slot spans over</summary>
	public  void SetColumnSpan(int InColumnSpan) {}
	///<summary>Sets positive values offset this cell to be hit-tested and drawn on top of others.</summary>
	public  void SetLayer(int InLayer) {}
	///<summary>Sets the offset for this slot&#39;s content by some amount; positive values offset to lower right</summary>
	public  void SetNudge(FVector2D InNudge) {}
	///<summary>SetHorizontalAlignment</summary>
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	///<summary>SetVerticalAlignment</summary>
	public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
}
