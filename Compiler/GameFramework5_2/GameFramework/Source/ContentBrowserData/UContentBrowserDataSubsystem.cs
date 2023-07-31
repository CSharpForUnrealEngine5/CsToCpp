#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Subsystem that provides access to Content Browser data.</summary>
[CppInclude("ContentBrowserDataSubsystem.h")]
public partial class UContentBrowserDataSubsystem : UEditorSubsystem {
	///<summary>Attempt to activate the named data source.</summary>
	public  bool ActivateDataSource(string Name) { return default; }
	///<summary>Attempt to deactivate the named data source.</summary>
	public  bool DeactivateDataSource(string Name) { return default; }
	///<summary>Activate all available data sources.</summary>
	public  void ActivateAllDataSources() {}
	///<summary>Deactivate all active data sources.</summary>
	public  void DeactivateAllDataSources() {}
	///<summary>Get the list of current available data sources.</summary>
	public  TArray<string> GetAvailableDataSources() { return default; }
	///<summary>Get the list of current active data sources.</summary>
	public  TArray<string> GetActiveDataSources() { return default; }
	///<summary>Get the items (folders and/or files) that exist under the given virtual path.</summary>
	public  TArray<FContentBrowserItem> GetItemsUnderPath(string InPath,FContentBrowserDataFilter InFilter) { return default; }
	///<summary>Get the items (folders and/or files) that exist at the given virtual path.</summary>
	public  TArray<FContentBrowserItem> GetItemsAtPath(string InPath,EContentBrowserItemTypeFilter InItemTypeFilter) { return default; }
	///<summary>Get the first item (folder and/or file) that exists at the given virtual path.</summary>
	public  FContentBrowserItem GetItemAtPath(string InPath,EContentBrowserItemTypeFilter InItemTypeFilter) { return default; }
	///<summary>Array of data source names that should be activated when available.</summary>
	public TArray<string> EnabledDataSources;
}
