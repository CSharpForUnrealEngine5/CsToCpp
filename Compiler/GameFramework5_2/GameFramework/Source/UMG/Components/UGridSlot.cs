#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/GridSlot.h")]
///<summary>A slot for UGridPanel, these slots all share the same size as the largest slot</summary>
public partial class UGridSlot : UPanelSlot {
// GridSlot
	public FMargin Padding;
	public EHorizontalAlignment HorizontalAlignment;
	public EVerticalAlignment VerticalAlignment;
	public int Row;
	public int RowSpan;
	public int Column;
	public int ColumnSpan;
	public int Layer;
	public FVector2D Nudge;
	public  void SetPadding(FMargin InPadding) {}
	public  void SetRow(int InRow) {}
	public  void SetRowSpan(int InRowSpan) {}
	public  void SetColumn(int InColumn) {}
	public  void SetColumnSpan(int InColumnSpan) {}
	public  void SetLayer(int InLayer) {}
	public  void SetNudge(FVector2D InNudge) {}
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
}
