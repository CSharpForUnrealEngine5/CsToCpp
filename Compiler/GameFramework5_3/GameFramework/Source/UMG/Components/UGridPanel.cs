namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A table-like panel that retains the width of every column throughout the table.</summary>
[CppInclude("Components/GridPanel.h")]
public partial class UGridPanel : UPanelWidget {
	public static UClass StaticClass() {return default;}
	///<summary>The column fill rules</summary>
	public TArray<float> ColumnFill;
	///<summary>The row fill rules</summary>
	public TArray<float> RowFill;
	///<summary>AddChildToGrid</summary>
	public UGridSlot AddChildToGrid(UWidget Content,int InRow/*=0*/,int InColumn/*=0*/) { return default; }
	///<summary>SetColumnFill</summary>
	public void SetColumnFill(int ColumnIndex,float Coefficient) {}
	///<summary>SetRowFill</summary>
	public void SetRowFill(int RowIndex,float Coefficient) {}
}
