namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/CSVImportFactory.h")]
public partial class UCSVImportFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>AutomatedImportSettings</summary>
	public FCSVImportSettings AutomatedImportSettings;
	///<summary>Temporary data table to use to display import options</summary>
	public UDataTable DataTableImportOptions;
}
