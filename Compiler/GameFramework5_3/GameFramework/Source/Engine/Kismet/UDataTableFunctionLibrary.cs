namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/DataTableFunctionLibrary.h")]
public partial class UDataTableFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>EvaluateCurveTableRow</summary>
	public static void EvaluateCurveTableRow(UCurveTable CurveTable,FName RowName,float InXY,EEvaluateCurveTableResult OutResult,float OutXY,string ContextString) {}
	///<summary>Returns whether or not Table contains a row named RowName</summary>
	public static bool DoesDataTableRowExist(UDataTable Table,FName RowName) { return default; }
	///<summary>GetDataTableRowNames</summary>
	public static void GetDataTableRowNames(UDataTable Table,TArray<FName> OutRowNames) {}
	///<summary>Export from the DataTable all the row for one column. Export it as string. The row name is not included.</summary>
	public static TArray<string> GetDataTableColumnAsString(UDataTable DataTable,FName PropertyName) { return default; }
	///<summary>Get a Row from a DataTable given a RowName</summary>
	public static bool GetDataTableRowFromName(UDataTable Table,FName RowName,FTableRowBase OutRow) { return default; }
	///<summary>Empty and fill a Data Table from CSV string.</summary>
	public static bool FillDataTableFromCSVString(UDataTable DataTable,string CSVString) { return default; }
	///<summary>Empty and fill a Data Table from CSV file.</summary>
	public static bool FillDataTableFromCSVFile(UDataTable DataTable,string CSVFilePath) { return default; }
	///<summary>Empty and fill a Data Table from JSON string.</summary>
	public static bool FillDataTableFromJSONString(UDataTable DataTable,string JSONString) { return default; }
	///<summary>Empty and fill a Data Table from JSON file.</summary>
	public static bool FillDataTableFromJSONFile(UDataTable DataTable,string JSONFilePath,UScriptStruct ImportRowStruct/*=nullptr*/) { return default; }
	///<summary>Add a row to a Data Table with the provided name and data.</summary>
	public static void AddDataTableRow(UDataTable DataTable,FName RowName,FTableRowBase RowData) {}
}
