namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/IO/PCGDataTableElement.h")]
public partial class UPCGLoadDataTableSettings : UPCGExternalDataSettings {
	public static UClass StaticClass() {return default;}
	///<summary>DataTable</summary>
	public TSoftObjectPtr<UDataTable> DataTable;
}
