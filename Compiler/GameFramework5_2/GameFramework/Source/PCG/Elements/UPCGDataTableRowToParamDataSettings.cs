namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGDataTableRowToParamData.h")]
public partial class UPCGDataTableRowToParamDataSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>The name of the row to copy from</summary>
	public FName RowName;
	///<summary>Path override, hidden to be only presented as param pin</summary>
	public string PathOverride;
	///<summary>the data table to copy from</summary>
	public TSoftObjectPtr<UDataTable> DataTable;
}
