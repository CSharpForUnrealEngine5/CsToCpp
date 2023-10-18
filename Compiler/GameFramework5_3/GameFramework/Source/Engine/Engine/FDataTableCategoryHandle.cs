namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handle to a particular set of rows in a table</summary>
[CppInclude("Engine/DataTable.h")]
public partial struct FDataTableCategoryHandle {
	public UDataTable DataTable;
	public FName ColumnName;
	public FName RowContents;
}
