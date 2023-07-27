#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserDataSubsystem.h")]
///<summary>Subsystem that provides access to Content Browser data.</summary>
public partial class UContentBrowserDataSubsystem : UEditorSubsystem {
// ContentBrowserDataSubsystem
	public  bool ActivateDataSource(string Name) { return default; }
	public  bool DeactivateDataSource(string Name) { return default; }
	public  void ActivateAllDataSources() {}
	public  void DeactivateAllDataSources() {}
	public  TArray<string> GetAvailableDataSources() { return default; }
	public  TArray<string> GetActiveDataSources() { return default; }
	public  TArray<FContentBrowserItem> GetItemsUnderPath(string InPath,FContentBrowserDataFilter InFilter) { return default; }
	public  TArray<FContentBrowserItem> GetItemsAtPath(string InPath,EContentBrowserItemTypeFilter InItemTypeFilter) { return default; }
	public  FContentBrowserItem GetItemAtPath(string InPath,EContentBrowserItemTypeFilter InItemTypeFilter) { return default; }
	public TArray<string> EnabledDataSources;
}
