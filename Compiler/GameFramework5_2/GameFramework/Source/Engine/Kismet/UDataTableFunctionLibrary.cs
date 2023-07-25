#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/DataTableFunctionLibrary.h")]
public partial class UDataTableFunctionLibrary : UBlueprintFunctionLibrary {
// DataTableFunctionLibrary
	public void EvaluateCurveTableRow(UObject CurveTable,string RowName,float InXY,byte OutResult,float OutXY,string ContextString) {}
	public bool DoesDataTableRowExist(UObject Table,string RowName) { return default; }
	public void GetDataTableRowNames(UObject Table,TArray<string> OutRowNames) {}
	public TArray<string> GetDataTableColumnAsString(UObject DataTable,string PropertyName) { return default; }
	public bool GetDataTableRowFromName(UObject Table,string RowName,FTableRowBase OutRow) { return default; }
	public bool FillDataTableFromCSVString(UObject DataTable,string CSVString) { return default; }
	public bool FillDataTableFromCSVFile(UObject DataTable,string CSVFilePath) { return default; }
	public bool FillDataTableFromJSONString(UObject DataTable,string JSONString) { return default; }
	public bool FillDataTableFromJSONFile(UObject DataTable,string JSONFilePath,UObject ImportRowStruct/*=nullptr*/) { return default; }
}
