#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Commandlets/ImportAssetsCommandlet.h")]
public partial class UImportAssetsCommandlet : UCommandlet {
	public static UClass StaticClass() {return default;}
	///<summary>Settings used when an import settings file is not used</summary>
	public UAutomatedAssetImportData GlobalImportData;
	///<summary>List of import data to import.  Each element in the list represents a list of assets using the same import settings</summary>
	public TArray<UAutomatedAssetImportData> ImportDataList;
}
