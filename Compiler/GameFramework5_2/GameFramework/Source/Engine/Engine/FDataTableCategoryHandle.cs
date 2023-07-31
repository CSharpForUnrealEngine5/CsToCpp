#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handle to a particular set of rows in a table</summary>
[CppInclude("Engine/DataTable.h")]
public partial struct FDataTableCategoryHandle {
	public UDataTable DataTable;
	public string ColumnName;
	public string RowContents;
}
