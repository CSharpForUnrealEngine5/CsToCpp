#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains data for a group of assets to import</summary>
[CppInclude("AssetImportTask.h")]
public partial class UAssetImportTask : UObject {
	///<summary>Filename to import</summary>
	public string Filename;
	///<summary>Path where asset will be imported to</summary>
	public string DestinationPath;
	///<summary>Optional custom name to import as (if you are using interchange the name must be set in a pipeline and this field will be ignored)</summary>
	public string DestinationName;
	///<summary>Overwrite existing assets</summary>
	public bool bReplaceExisting;
	///<summary>Replace existing settings when overwriting existing assets</summary>
	public bool bReplaceExistingSettings;
	///<summary>Avoid dialogs</summary>
	public bool bAutomated;
	///<summary>Save after importing</summary>
	public bool bSave;
	///<summary>Perform the import asynchronously for file formats where async import is available</summary>
	public bool bAsync;
	///<summary>Optional factory to use</summary>
	public UFactory Factory;
	///<summary>Import options specific to the type of asset</summary>
	public UObject Options;
	///<summary>Get the list of imported objects.</summary>
	public  TArray<UObject> GetObjects() { return default; }
	///<summary>Query whether this asynchronous import task is complete, and the results are ready to read.</summary>
	public  bool IsAsyncImportComplete() { return default; }
	///<summary>Paths to objects created or updated after import</summary>
	public TArray<string> ImportedObjectPaths;
	///<summary>Result</summary>
	public TArray<UObject> Result;
}
