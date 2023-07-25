#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomatedAssetImportData.h")]
///<summary>Contains data for a group of assets to import</summary>
public partial class UAutomatedAssetImportData : UObject {
// AutomatedAssetImportData
	public string GroupName;
	public TArray<string> Filenames;
	public string DestinationPath;
	public string FactoryName;
	public bool bReplaceExisting;
	public bool bSkipReadOnly;
	public UFactory Factory;
	public string LevelToLoad;
}
