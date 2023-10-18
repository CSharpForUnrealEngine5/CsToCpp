namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Subsystem that provides access to Content Browser data.</summary>
[CppInclude("ContentBrowserDataSubsystem.h")]
public partial class UContentBrowserDataSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Attempt to activate the named data source.</summary>
	public bool ActivateDataSource(FName Name) { return default; }
	///<summary>Attempt to deactivate the named data source.</summary>
	public bool DeactivateDataSource(FName Name) { return default; }
	///<summary>Activate all available data sources.</summary>
	public void ActivateAllDataSources() {}
	///<summary>Deactivate all active data sources.</summary>
	public void DeactivateAllDataSources() {}
	///<summary>Get the list of current available data sources.</summary>
	public TArray<FName> GetAvailableDataSources() { return default; }
	///<summary>Get the list of current active data sources.</summary>
	public TArray<FName> GetActiveDataSources() { return default; }
	///<summary>Get the items (folders and/or files) that exist under the given virtual path.</summary>
	public TArray<FContentBrowserItem> GetItemsUnderPath(FName InPath,FContentBrowserDataFilter InFilter) { return default; }
	///<summary>Get the items (folders and/or files) that exist at the given virtual path.</summary>
	public TArray<FContentBrowserItem> GetItemsAtPath(FName InPath,EContentBrowserItemTypeFilter InItemTypeFilter) { return default; }
	///<summary>Get the first item (folder and/or file) that exists at the given virtual path.</summary>
	public FContentBrowserItem GetItemAtPath(FName InPath,EContentBrowserItemTypeFilter InItemTypeFilter) { return default; }
	///<summary>Array of data source names that should be activated when available.</summary>
	public TArray<FName> EnabledDataSources;
}
