namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handle to a particular row in a table</summary>
[CppInclude("Engine/DataTable.h")]
public partial struct FDataTableRowHandle {
	public UDataTable DataTable;
	public FName RowName;
}
