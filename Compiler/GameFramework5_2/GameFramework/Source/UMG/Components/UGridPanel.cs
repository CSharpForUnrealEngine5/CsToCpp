#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/GridPanel.h")]
///<summary>A table-like panel that retains the width of every column throughout the table.</summary>
public partial class UGridPanel : UPanelWidget {
// GridPanel
	public TArray<float> ColumnFill;
	public TArray<float> RowFill;
	public  UGridSlot AddChildToGrid(UWidget Content,int InRow/*=0*/,int InColumn/*=0*/) { return default; }
	public  void SetColumnFill(int ColumnIndex,float Coefficient) {}
	public  void SetRowFill(int RowIndex,float Coefficient) {}
}
