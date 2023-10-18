namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A slot for UUniformGridPanel, these slots all share the same size as the largest slot</summary>
[CppInclude("Components/UniformGridSlot.h")]
public partial class UUniformGridSlot : UPanelSlot {
	public static UClass StaticClass() {return default;}
	///<summary>The alignment of the object horizontally.</summary>
	public EHorizontalAlignment HorizontalAlignment;
	///<summary>The alignment of the object vertically.</summary>
	public EVerticalAlignment VerticalAlignment;
	///<summary>The row index of the cell this slot is in</summary>
	public int Row;
	///<summary>The column index of the cell this slot is in</summary>
	public int Column;
	///<summary>Sets the row index of the slot, this determines what cell the slot is in the panel</summary>
	public void SetRow(int InRow) {}
	///<summary>Sets the column index of the slot, this determines what cell the slot is in the panel</summary>
	public void SetColumn(int InColumn) {}
	///<summary>SetHorizontalAlignment</summary>
	public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	///<summary>SetVerticalAlignment</summary>
	public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
}
