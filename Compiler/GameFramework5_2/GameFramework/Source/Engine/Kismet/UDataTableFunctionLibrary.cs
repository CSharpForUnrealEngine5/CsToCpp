#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/DataTableFunctionLibrary.h")]
public partial class UDataTableFunctionLibrary : UBlueprintFunctionLibrary {
// DataTableFunctionLibrary
	public static void EvaluateCurveTableRow(UCurveTable CurveTable,string RowName,float InXY,byte OutResult,float OutXY,string ContextString) {}
	public static bool DoesDataTableRowExist(UDataTable Table,string RowName) { return default; }
	public static void GetDataTableRowNames(UDataTable Table,TArray<string> OutRowNames) {}
	public static TArray<string> GetDataTableColumnAsString(UDataTable DataTable,string PropertyName) { return default; }
	public static bool GetDataTableRowFromName(UDataTable Table,string RowName,FTableRowBase OutRow) { return default; }
	public static bool FillDataTableFromCSVString(UDataTable DataTable,string CSVString) { return default; }
	public static bool FillDataTableFromCSVFile(UDataTable DataTable,string CSVFilePath) { return default; }
	public static bool FillDataTableFromJSONString(UDataTable DataTable,string JSONString) { return default; }
	public static bool FillDataTableFromJSONFile(UDataTable DataTable,string JSONFilePath,UScriptStruct ImportRowStruct/*=nullptr*/) { return default; }
}
